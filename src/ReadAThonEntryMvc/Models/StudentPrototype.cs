using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.Practices.ServiceLocation;
using ReadAThonEntry.Core.DTOs;
using ReadAThonEntry.Core.Repositories;

namespace ReadAThonEntryMvc.Models
{
 
    public class StudentPrototype
    { 
        public string EnvelopeNumber { get; set; }
        public string Grade { get; set; }
        public long Teacher { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SchoolName { get; set; }
        public long SchoolId { get; set; }
        public string MinutesRead { get; set; }
        public string PagesRead { get; set; }
        public string ReadingGoal { get; set; }
        public string Comments { get; set; }
        public string ShirtSize { get; set; }
        public string AmountFromWebsite { get; set; }
        public string AmountFromEnvelope { get; set; }
        public string FundraisingGoal { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string ValidationErrorMsgs { get; set; }

        public bool CreateNewSchool
        { get; set; }

        public string GetSelected(string size)
        {
            return size == ShirtSize ? "selected" : "";
        }

        public IEnumerable<SelectListItem> GetTeachers()
        {
            var contactQry = ServiceLocator.Current.GetInstance<ISchoolRepository>();
            var school = contactQry.Find(s => s.Id == SchoolId);
            var lst = school.Contacts.Where(c => c.Title == "Teacher").Select(getListItem).ToList();
            lst.Add(new SelectListItem(){Selected = true, Text = "<Select a teacher>", Value = "0"});
            return lst.OrderBy(t => t.Text);
        }

        private SelectListItem getListItem(ContactDto contact)
        {
            var display = DisplayName(contact);
            var item = new SelectListItem { Text = display, Value = contact.Id.ToString() };
            return item;
        }

        private static string DisplayName(ContactDto contact)
        { 

                if (contact.FirstName == null)
                    return contact.LastName;
                return contact.LastName + ", " + contact.FirstName; 
        }
    }
}