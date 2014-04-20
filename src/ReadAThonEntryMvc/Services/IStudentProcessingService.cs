using System;
using System.Text; 
using ReadAThonEntry.Core.DTOs;
using ReadAThonEntry.Core.Repositories; 
using CJR.Common.Extensions;
using ReadAThonEntryMvc.Models;

namespace ReadAThonEntryMvc.Services
{
    public interface IStudentProcessingService    
    {
        bool ValidateAndInsert(StudentPrototype requestPrototype, IStudentMappingHelper helper);
        bool ValidateAndUpdate(Student requestPrototype, IStudentMappingHelper helper);
    }

    public class StudentProcessingService : IStudentProcessingService
    {
        private readonly IStudentRepository _studentRepo;

        public StudentProcessingService(IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo; 
        }

//        public bool ValidateAndSave(StudentPrototype request)
//        {
//            if (!validate(request))
//                return false;
//            var teacher = getContactDto(request);
//            _studentRepo.Save(request.MapFromPrototype(teacher));
//            if (request.CreateNewSchool)
//            {
//                _schoolRepo.Save(new SchoolDto() { Name = request.School.Name });
//            }
//            return true;
//        }

        private static bool validate(Student request)
        {
            request.ValidationErrorMsgs = "";
            var valMsgs = new StringBuilder(); 
            if (request.EnvelopeNumber.IsNullOrEmpty())
                valMsgs.AppendLine("Envelope Number is required!"); 
            if (valMsgs.Length == 0)
                return true;
            request.ValidationErrorMsgs = valMsgs.ToString();
            return false;
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

        public bool ValidateAndInsert(StudentPrototype request, IStudentMappingHelper helper)
        { 
            if (!validate(request))
                return false;
            var dto = _studentRepo.Find(s => s.FirstName == request.FirstName 
                && s.LastName == request.LastName
                && s.SchoolName == request.SchoolName);
            if(dto != null)
                throw new Exception(string.Format("Student {0} {1} is already in the database.", request.FirstName, request.LastName));
            _studentRepo.Save(request.MapFromPrototype(helper));
            return true;
        }



        public bool ValidateAndUpdate(Student request, IStudentMappingHelper helper)
        { 
            if (!validate(request))
                return false; 
            _studentRepo.WithinUpdateContext(() =>
                {
                    var entity = _studentRepo.Find(e => e.Id == request.Id);
                    helper.LoadPrototype(request);
                    request.MergeWithModel(entity,helper); 
                });
            return true;
        }
    }
}