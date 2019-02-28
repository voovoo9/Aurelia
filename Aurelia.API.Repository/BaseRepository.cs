using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Npgsql;

namespace Aurelia.API.Repository
{
    public class BaseRepository
    {
        protected IDbConnection db;
        
        public BaseRepository()
        {
            string connectionString = "Host=localhost;Username=<Vukasin Vukotic>;Password=<mypass>;Database=AureliaAPIData";
            db = new NpgsqlConnection(connectionString);
        }
    }
}
