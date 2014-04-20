using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ReadAThonEntryMvc.Models
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }
        public  string Address1 { get; set; }
        public  string Address2 { get; set; }
        public  string City { get; set; }
        public  string State { get; set; }
        public  string Zip { get; set; }
        public string Phone { get; set; }
        public int NumberOfClassrooms { get; set; }
//        public IEnumerable<SelectListItem> GetTeachers()
//        {
//            var lst = Contacts.Where(c => c.Title.TitleName == "Teacher").Select(getListItem).ToList();
//            lst.Add(new SelectListItem() { Selected = true, Text = "<Select a teacher>", Value = "0" });
//            return lst.OrderBy(t => t.Text);
//        }

//        private SelectListItem getListItem(Contact contact)
//        {
//            var item = new SelectListItem {Text = contact.DisplayName, Value = contact.Id.ToString()};
//            return item;
//        }
//
//        public SelectListItem GetDefaultTeacher()
//        {
//            return new SelectListItem() {Text = "Please select a teacher", Value = "0"};
//        }

 
    }

   
}