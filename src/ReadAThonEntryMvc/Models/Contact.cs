using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.Practices.ServiceLocation;
using ReadAThonEntry.Core.DTOs;
using ReadAThonEntry.Core.Repositories;

namespace ReadAThonEntryMvc.Models
{
    public class Contact
    {
 

    public Contact( )
        { 
        }
        public static IEnumerable<SelectListItem> GetTitles()
        {
            var repoInstance = ServiceLocator.Current.GetInstance<ITitleRepository>();
            return repoInstance.GetAll().Select(getListItem).OrderBy(t => t.Text);

        }

        public static IEnumerable<SelectListItem> GetTeachers(string schoolName)
        {

            var contactQry = ServiceLocator.Current.GetInstance<ISchoolRepository>();
            var school = contactQry.Find(s => s.Name == schoolName);
            var lst = school.Contacts.Where(c => c.Title == "Teacher").Select(getContactListItem).ToList();
            lst.Add(new SelectListItem() { Selected = true, Text = "<Select a teacher>", Value = "0" });
            return lst.OrderBy(t => t.Text);
        }

 
        public string GetSelectedTitle(string title)
        {
            if (Title == null) return "";
            return Title  == title ? "selected" : "";
        }

        public string GetSelectedSize(string size)
        {
            return size == ShirtSize ? "selected" : "";
        }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string School { get; set; }
        public long SchoolId { get; set; }
        public string Title { get; set; }  

        public string DisplayName {get
        {

            if (FirstName == null)
                return LastName;
            return LastName + ", " + FirstName;
        }}
        public long Id { get; set; }

        public string ShirtSize { get; set; }


        private static SelectListItem getContactListItem(ContactDto contact)
        {
            var display = contact.DisplayName();
            var item = new SelectListItem { Text = display, Value = contact.Id.ToString() };
            return item;
        }
        private static SelectListItem getListItem(TitleDto title)
        {
            var item = new SelectListItem { Text = title.TitleName, Value = title.Id.ToString() };
            return item;
        }
    }
}