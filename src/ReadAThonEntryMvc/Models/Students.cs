using System.Collections.Generic;

namespace ReadAThonEntryMvc.Models
{
    public class Students
    {
        public Students(StudentSearchCriteria criteria, IEnumerable<Student> studenList)
        {
            School = criteria.School;
            FirstNamesStartingWith = criteria.FirstName;
            LastNamesStartingWith = criteria.LastName;
            this.StudentList = studenList; 
        }

        public string FirstNamesStartingWith
        {
            get; set;
        }
        public string LastNamesStartingWith
        {
            get;
            set;
        }
        public string School
        {
            get; private set;
        }
        public IEnumerable<Student> StudentList     
        { 
            get; private set; 
        }

        public static string GetFirstName(string fullName)
        {
            return fullName.Split(",".ToCharArray())[0];
        }
        public static string GetLastName(string fullName)
        {
            return fullName.Split(",".ToCharArray())[1];
        }
    }
}