using Dapper;
using Aurelia.API.Entities;
using Aurelia.API.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace Aurelia.API.Repository
{
    public class FormRepository : BaseRepository, IFormRepository
    {
        public void AddForm(Form form)
        {
            db.Execute("AddForm", new { form.Email, form.FirstName, form.LastName }, commandType: CommandType.StoredProcedure);
        }

        public void DeleteForm(int id)
        {
            db.Execute("DeleteForm", id, commandType: CommandType.StoredProcedure);
        }

        public List<Form> GetAllForms()
        {
            return db.Query<Form>("GetAllForms", commandType: CommandType.StoredProcedure).ToList();
        }

        public Form GetFormById(int id)
        {
            return db.Query<Form>("GetFormById", id, commandType: CommandType.StoredProcedure).SingleOrDefault();
        }

        public void UpdateForm(Form form)
        {
            db.Execute("UpdateForm", new { form.Email, form.FirstName, form.LastName }, commandType: CommandType.StoredProcedure);
        }
    }
}
