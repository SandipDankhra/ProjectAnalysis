using Microsoft.EntityFrameworkCore;
using StudentInfoApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfoApp.Domain
{
    public abstract class BaseDomain : DbContext
    {
        private SqlConnection SqlConnection { get; set; }
        protected SqlCommand SqlCommand { get; set; }


        public BaseDomain()
        {
            this.SqlConnection = new SqlConnection("data source=S\\SQLEXPRESS;initial catalog=StudentInfoDb;Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework");
            this.SqlConnection.Open();
        }


        public SqlDataReader GetReader(string commandText)
        {
            this.SqlCommand = new SqlCommand(commandText, this.SqlConnection);
            return this.SqlCommand.ExecuteReader();
        }

        public void ExecuteNonQuery(string commandText)
        {
            this.SqlCommand = new SqlCommand(commandText, this.SqlConnection);
            this.SqlCommand.ExecuteNonQuery();
        }

        public void CloseConnection()
        {
            this.SqlConnection.Close();
        }

        public DbSet<Students>  students { get; set; }
     

    }
}
