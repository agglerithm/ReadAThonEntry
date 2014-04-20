using System;
using System.Collections.Generic;
using PullReadAThonData.Data;
using ReadAThonEntry.Core;

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
             
            var downloadRepo = ServiceLocator.Current.GetInstance<IStudentDownloadRepository>();
            var errorRepo = ServiceLocator.Current.GetInstance<IStudentErrorRepository>();
            persistStudents(students, downloadRepo, errorRepo);
            Console.WriteLine("Done!");
            Console.WriteLine("Press space bar to exit program.");
            Console.ReadKey();


        }

        
        private static void persistStudents(IEnumerable<StudentPackage> students, 
            IStudentDownloadRepository downloadRepo, IStudentErrorRepository errorRepo)
        {
            try
            {
                students.ForEach(s => saveStudent(s, downloadRepo, errorRepo)); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! " + ex.Message);
            }
        }

        private static void saveStudent(StudentPackage stPkg, IStudentDownloadRepository repo,
                                        IStudentErrorRepository errorRepo)
        {
            try
            {
                repo.Save(stPkg);
            }

            catch (Exception  ex)
                    { 
                        errorRepo.Save(stPkg, ex);
                    } 
   
        }
     
        private static IEnumerable<StudentPackage> getStudents(string responseText)
        {
            var parser = ServiceLocator.Current.GetInstance<IStudentReportParser>();

            return parser.GetStudentsFrom(responseText);

        }


    }
}
