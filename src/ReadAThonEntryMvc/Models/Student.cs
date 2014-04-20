using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ReadAThonEntry.Core.Repositories;

namespace ReadAThonEntryMvc.Models
{
    public class Student
    {
        public long Id { get; set; }
        public string EnvelopeNumber { get; set; }
        public  string Grade { get; set; }
        public long TeacherId { get; set; }
        public string TeacherName { get; set; }
        public  string FirstName { get; set; }
        public  string LastName { get; set; } 
        public string SchoolName { get; set; }
        public  int MinutesRead { get; set; }
        public int PagesRead { get; set; }
        public int ReadingGoal { get; set; }
        public   string Comments { get; set; }
        public   string ShirtSize { get; set; }
        public   decimal AmountFromWebsite { get; set; }
        public decimal AmountFromEnvelope { get; set; }
        public decimal  FundraisingGoal { get; set; }
        public   string Address1 { get; set; }
        public   string Address2 { get; set; }
        public   string City { get; set; }
        public   string State { get; set; }
        public  string Zip { get; set; }
        public   string Phone { get; set; }
        public string ValidationErrorMsgs { get; set; }

        public string GetSelected(string size)
        {
            return size == ShirtSize ? "selected" : ""  ;
        }

        public string GetSelectedTeacher(int teacherId)
        {
            return TeacherId == teacherId ? "selected" : "";
        }

        public IEnumerable<Prize> Prizes { get; set; }

        public static IEnumerable<string> GetAll()
        {
            var year = DateTime.Today.Year;
            var repo = DependencyResolver.Current.GetService<IStudentRepository>();
            return  repo.Query(d => d.YearOf == year).Select(s => string.Format("{0}, {1}", s.LastName, s.FirstName));
        }
    }
}