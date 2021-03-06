﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Text;
using MoviesStoreApp.Models;

namespace MoviesStoreApp.Domains
{
    public abstract class BaseDomain:DbContext
    {
        private SqlConnection SqlConnection { get; set; }
        protected SqlCommand SqlCommand { get; set; }


        public BaseDomain()
        {
            this.SqlConnection = new SqlConnection("data source=S\\SQLEXPRESS;initial catalog=MoviesInformationDB;Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework");
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

        public DbSet<Movies> Movies { get; set; }
        public DbSet<MovieDetails> MovieDetails { get; set; }
        public DbSet<Actors> Actors{ get; set; }

    }
}
