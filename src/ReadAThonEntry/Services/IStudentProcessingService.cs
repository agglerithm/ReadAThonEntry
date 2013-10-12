namespace ReadAThonEntry.Services
{
    using System;
    using System.Text;
    using Core.DTOs;
    using Core.Repositories;
    using ViewModels;
    using CJR.Common.Extensions;

    public interface IStudentProcessingService    
    {
        bool ValidateAndInsert(StudentPrototype requestPrototype);
        bool ValidateAndUpdate(StudentPrototype requestPrototype);
    }

    public class StudentProcessingService : IStudentProcessingService
    {
        private readonly IStudentRepository _studentRepo;
        private readonly ISchoolRepository _schoolRepo;

        public StudentProcessingService(IStudentRepository studentRepo, ISchoolRepository schoolRepo)
        {
            _studentRepo = studentRepo;
            _schoolRepo = schoolRepo;
        }

        public bool ValidateAndSave(StudentPrototype request)
        {
            if (!validate(request))
                return false;
            _studentRepo.Save(request.MapFromPrototype());
            if (request.CreateNewSchool)
            {
                _schoolRepo.Save(new SchoolDto() { Name = request.School });
            }
            return true;
        }

        private static bool validate(StudentPrototype request)
        {
            request.ValidationErrorMsgs = "";
            var valMsgs = new StringBuilder();
            string suffix = "should be a numeric value!  ";
            if (request.EnvelopeNumber.IsNullOrEmpty())
                valMsgs.AppendLine("Envelope Number is required!");
            if (!request.AmountFromEnvelope.IsNumeric())
                valMsgs.AppendLine("'Amount from Envelope' " + suffix);
            if (!request.AmountFromWebsite.IsNumeric())
                valMsgs.AppendLine("'Amount from Website' " + suffix);
            if (!request.MinutesRead.IsNumeric())
                valMsgs.AppendLine("'Minutes Read' " + suffix);
            if (!request.PagesRead.IsNumeric())
                valMsgs.AppendLine("'Pages Read' " + suffix);
            if (!request.ReadingGoal.IsNumeric())
                valMsgs.AppendLine("'Reading Goal' " + suffix);
            if (valMsgs.Length == 0)
                return true;
            request.ValidationErrorMsgs = valMsgs.ToString();
            return false;
        }

        public bool ValidateAndInsert(StudentPrototype request)
        {
            if (!validate(request))
                return false;
            _studentRepo.Save(request.MapFromPrototype());
            if (request.CreateNewSchool)
            {
                _schoolRepo.Save(new SchoolDto() { Name = request.School });
            }
            return true;
        }

        public bool ValidateAndUpdate(StudentPrototype request)
        {
            if (!validate(request))
                return false;
            _studentRepo.WithinUpdateContext(() =>
                {
                    var entity = _studentRepo.Find(e => e.FirstName == request.FirstName
                                                        && e.LastName == request.LastName
                                                        && e.Address1 == request.Address1);
                    request.MergeWithPrototype(entity);
                });
            return true;
        }
    }
}