using BusinessInfoApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessInfoApp.Domain
{
    public class ProjectDomain
    {
        BaseContext BaseContexts = new BaseContext();
        Project project = new Project();

        public void addProject()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection("data source=S\\SQLEXPRESS;initial catalog=BusinessInfoDb;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.CommandText = "spAddProject";
                sqlCommand.Connection = sqlConnection;

                Console.Write("Enter Project Name : ");
                string ProjectName = Convert.ToString(Console.ReadLine());

                Console.Write("Enter Employee ID : ");
                int EmployeeId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Project Description : ");
                string Description = Convert.ToString(Console.ReadLine());

                Console.Write("Enter Project Type : ");
                string ProjectType = Convert.ToString(Console.ReadLine());

                Console.Write("Enter Project ProjectDuration : ");
                string ProjectDuration = Convert.ToString(Console.ReadLine());

                Console.Write("Enter project ProjectStartDate : ");
                DateTime ProjectStartDate = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Enter project ProjectEndDate : ");
                DateTime ProjectEndDate = Convert.ToDateTime(Console.ReadLine());

                sqlCommand.Parameters.Add("@ProjectName", ProjectName);
                sqlCommand.Parameters.Add("@EmployeeId", EmployeeId);
                sqlCommand.Parameters.Add("@Description", Description);
                sqlCommand.Parameters.Add("@ProjectType", ProjectType);
                sqlCommand.Parameters.Add("@ProjectDuration", ProjectDuration);
                sqlCommand.Parameters.Add("@ProjectStartDate", ProjectStartDate);
                sqlCommand.Parameters.Add("@ProjectEndDate", ProjectEndDate);

                sqlConnection.Open();
                var sql = sqlCommand.ExecuteNonQuery();
                if (sql == null)
                {
                    Console.WriteLine("Project Details Can not be inserted...");
                }
                else
                {
                    BaseContexts.SaveChanges();
                    Console.WriteLine("\nProject Details inserted Successfully");
                    sqlConnection.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }


        }

        public void viewAllProject()
        {
            try
            {
                var ProjectList = BaseContexts.vProjectDetailRecords;
                Console.WriteLine("ProjectName\tProjectType\tProjectDuration\tProjectStartDate" +
                    "\tProejctEndDate\tName\t");
                foreach (var vProject in ProjectList)
                {
                    Console.WriteLine(vProject.ProjectName+ "\t"
                        + vProject.ProjectType + "\t"
                        + vProject.ProjectDuration+ "\t" 
                        + vProject.ProjectStartDate + "\t"
                        + vProject.ProejctEndDate + "\t"
                        + vProject.Name);
                }

                //  BaseContexts.Employees.ToList();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
