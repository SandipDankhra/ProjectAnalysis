using StudentInfoApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfoApp.Domain
{
    public class StudentDomain : BaseDomain
    {
        public void Add(Students students)
        {
            this.ExecuteNonQuery($"insert into Students values ('{students.Name}','{students.MobileNumber}','{students.EmailId}','{students.Course}',{students.Enrolle},'{students.Fees}')");
        }
        public void Update(Students students)
        {
            this.ExecuteNonQuery($"update Students set Name='{students.Name}',MobileNumber='{students.MobileNumber}',EmailId='{students.EmailId}',Course='{students.Course}',Enrolle='{students.Enrolle}',Fees={students.Fees} where StudentId = {students.StudentId}");
        }
        public void Delete(int StudentId)
        {
            this.ExecuteNonQuery($"delete from Students where StudentId = {StudentId}");
        }
        public void Get(Students students)
        {
            var reader = this.GetReader($"select * from Students");

            while (reader.Read())
            {

                Console.WriteLine(reader.GetInt32(0) + "\t"
                    + reader.GetString(1) + "\t"
                    + reader.GetString(2) + "\t"
                    + reader.GetString(3) + "\t"
                    + reader.GetString(4) + "\t"
                    + reader.GetString(5) + "\t"
                    + reader.GetInt32(6));

            }
        }
    }
}
