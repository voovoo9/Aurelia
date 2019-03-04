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
        public void AddForm (Form form)
        {
            db.Execute("INSERT INTO Form (Email, FirstName, LastName) VALUES (@Email, @FirstName, @LastName)", new { form.Email, form.FirstName, form.LastName });
        }

        public void DeleteForm(int id)
        {
            db.Execute("DELETE FROM Form WHERE Id=@id", new { id });
        }

        public List<Form> GetAllForms()
        {
            return db.Query<Form>("SELECT * FROM Form").ToList();
        }

        public Form GetFormById(int id)
        {
            return db.Query<Form>("SELECT * FROM Form WHERE Id = @id", new { id }).SingleOrDefault();
        }

        public void UpdateForm(int id, Form form)
        {
            var sql =
                "UPDATE Form " +
                "SET FirstName = @FirstName, " +
                "    LastName  = @LastName, " +
                "    Email     = @Email " +
                "WHERE Id = @id";
            db.Execute(sql, new { form.Email, form.FirstName, form.LastName, id});
        }

        //Kod za stored procedures:

        //public void AddForm(Form form)
        //{
        //    db.Execute("AddForm", new { form.Email, form.FirstName, form.LastName }, commandType: CommandType.StoredProcedure);
        //}

        //public void DeleteForm(int id)
        //{
        //    db.Execute("DeleteForm", id, commandType: CommandType.StoredProcedure);
        //}

        //public List<Form> GetAllForms()
        //{
        //    return db.Query<Form>("GetAllForms", commandType: CommandType.StoredProcedure).ToList();
        //}

        //public Form GetFormById(int id)
        //{
        //    return db.Query<Form>("GetFormById", id, commandType: CommandType.StoredProcedure).SingleOrDefault();
        //}

        //public void UpdateForm(Form form)
        //{
        //    db.Execute("UpdateForm", new { form.Email, form.FirstName, form.LastName }, commandType: CommandType.StoredProcedure);
        //}
    }
}
