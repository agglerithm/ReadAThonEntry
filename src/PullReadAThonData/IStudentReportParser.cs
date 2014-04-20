using ReadAThonEntry.Core;
using ReadAThonEntry.Core.Repositories;

namespace PullReadAThonData
{ 
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using CJR.Common.Extensions;
    using ReadAThonEntry.Core.DTOs;

    public interface IStudentReportParser
    {
        IEnumerable<StudentPackage> GetStudentsFrom(string responseText);
    }

    public class StudentReportParser : IStudentReportParser
    {
        private ISchoolRepository _schoolRepo;

        public StudentReportParser(ISchoolRepository schoolRepo)
        {
            _schoolRepo = schoolRepo;
        }

        public IEnumerable<StudentPackage> GetStudentsFrom(string responseText)
        {
            var x = getXmlFromResponse(responseText);

            var rows = x.Elements("tr");

            var students = rows.Select(getStudentFromRow).EagerLoad();

            return students;
        }

        private StudentPackage getStudentFromRow(XElement row)
        {
            var pkg = new StudentPackage();
            var elements = row.Elements("td");
            var arr = elements.ToArray();
            var s = new StudentDto();
            s.FirstName = arr[0].Value;
            s.LastName = arr[1].Value;
            s.AmountFromWebsite = arr[5].Value.CastToDecimal();
            s.Address1 = arr[8].Value;
            s.Address2 = arr[9].Value;
            s.City = arr[10].Value;
            s.State = arr[11].Value;
            s.Zip = arr[12].Value;
            s.Phone = arr[13].Value;
            var school = new SchoolDto() {Name = correctSchoolName(arr[14].Value)};
            var teacher = new ContactDto() { LastName = arr[15].Value, Title = "Teacher" };
  
            s.Grade = arr[16].Value;
            pkg.school = school;
            pkg.teacher = teacher;
            pkg.student = s;
            return pkg;
        }

        private string correctSchoolName(string value)
        {
            if (value.Contains("Girls"))
                return "GSA - The Girls' School of Austin";
            return value;
        }

        private static XElement getXmlFromResponse(string txt)
        {

            txt = txt.Replace("<TR>", "<tr>").Replace("&","");

            var startPos = txt.IndexOf("<tr>");
            var endPos = txt.IndexOf("</body>");

            txt = txt.Substring(startPos, endPos - startPos);

              txt = "<contents>" + txt.Trim() + "</contents>";
            return XElement.Parse(txt);
        }
    }
}