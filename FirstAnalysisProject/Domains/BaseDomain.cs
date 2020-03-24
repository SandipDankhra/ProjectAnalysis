using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace FirstAnalysisProject.Domains
{
    public class BaseDomain
    {
        private SqlConnection SqlConnection { get; set; };

        public BaseDomain()
        {
           // this.SqlConnection =
        }
    }
}