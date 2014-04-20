using CJR.Common.Extensions;
using ReadAThonEntry.Core.DTOs;
using ReadAThonEntry.Core.Repositories;
using ReadAThonEntryMvc.Models;

namespace ReadAThonEntryMvc.Services
{
    public interface IStudentMappingHelper
    {
        SchoolDto School { get; }
        ContactDto Teacher { get; }
        void LoadPrototype(StudentPrototype prototype);
        StudentPrototype CreatePrototype(string first, string last, long schoolId);
        void LoadPrototype(Student prototype);
    }

    public class StudentMappingHelper : IStudentMappingHelper
    { 
        private readonly ISchoolRepository _schoolRepo;

        public StudentMappingHelper(ISchoolRepository schoolRepo)
        {
            _schoolRepo = schoolRepo;
        }
        public SchoolDto School { get; private set; }
        public ContactDto Teacher { get; private set; }
        public void LoadPrototype(StudentPrototype prototype)
        { 
            School = _schoolRepo.Find(s => s.Id == prototype.SchoolId);
            prototype.SchoolName = School.Name;
            Teacher = getContactDto(prototype);
        }

        public StudentPrototype CreatePrototype(string first, string last, long schoolId)
        {
            var school = _schoolRepo.Find(s => s.Id == schoolId);
            return new StudentPrototype()
            {
                FirstName = first,
                LastName = last,
                SchoolName = school.Name,
                SchoolId = school.Id,
                ValidationErrorMsgs = "Student " + first + " " + last + " from " + school.Name + " was not found.  Please enter the student's information here."
            };
        }

        public void LoadPrototype(Student prototype)
        {
            School = _schoolRepo.Find(s => s.Name == prototype.SchoolName); 
            Teacher = getContactDto(prototype);
        }

        private ContactDto getContactDto(Student request)
        { 
            var teacher = School.Contacts.Find(c => c.Id == request.TeacherId);
            return teacher;
        }

        private ContactDto getContactDto(StudentPrototype request)
        {
            var schoolDto = _schoolRepo.Find(s => s.Id == request.SchoolId);
            var teacher = schoolDto.Contacts.Find(c => c.Id == request.Teacher);
            return teacher;
        }
    }
}