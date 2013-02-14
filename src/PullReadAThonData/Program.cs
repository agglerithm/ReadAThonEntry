using System;
using System.Collections.Generic;

namespace PullReadAThonData
{
    using System.Configuration;
    using System.Linq;
    using CJR.Common.Extensions;
    using CjrHttp.Wrappers;
    using Configs;
    using Microsoft.Practices.ServiceLocation;
    using ReadAThonEntry.Core.DTOs;
    using ReadAThonEntry.Core.Repositories;

    class Program
    {
        static void Main(string[] args)
        {
            var dbPath = ConfigurationManager.AppSettings["SQLConnection"];
            Console.WriteLine("Before continuing, ensure data has been cleaned up in Access database (" + dbPath + ")");
            Console.WriteLine("Press space bar to continue....");
            Console.ReadKey();

            Console.WriteLine("Loading dependencies..."); 
            StructureMapBootstrapper.Execute();
            Console.WriteLine(" Downloading data...");
            var connection = ServiceLocator.Current.GetInstance<IHttpConnectionWrapper>();

            var response = connection.GetInitialResponse(ConfigurationManager.AppSettings["DownloadURL"]);
            Console.WriteLine(" Building student information...");

            var students = getStudents(response.ResponseText);

            Console.WriteLine(" Saving to the database...");

            var repo = ServiceLocator.Current.GetInstance<IStudentRepository>();
            var errorRepo = ServiceLocator.Current.GetInstance<IStudentErrorRepository>();
            persistStudents(students, repo, errorRepo);
            Console.WriteLine("Done!");
            Console.WriteLine("Press space bar to exit program.");
            Console.ReadKey();


        }

        private static void persistStudents(IEnumerable<StudentDto> students, IStudentRepository repo, IStudentErrorRepository errorRepo)
        {
            try
            {
            students.Where(st => st.School != "INDIVIDUAL").ForEach(s =>
                                                                        {
                                                                            try
                                                                            {
                                                                                s.YearOf = DateTime.Today.Year;
                                                                                repo.Save(s);
                                                                            }
                                                                            catch (Exception ex)
                                                                            {
                                                                                errorRepo.Save(new StudentErrorDto(s, ex));
                                                                            }
                                                                        });
            students.Where(st => st.School == "INDIVIDUAL").ForEach(s =>
                                                                        {
                                                                            s.YearOf = DateTime.Today.Year;
                                                                            errorRepo.Save(new StudentErrorDto(s, new Exception("No such school")));
                                                                        }
                );

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! " + ex.Message);
            }
        }

        private static IEnumerable<StudentDto> getStudents(string responseText)
        {
            var parser = ServiceLocator.Current.GetInstance<IStudentReportParser>();

            return parser.GetStudentsFrom(responseText);

        }


    }
}
