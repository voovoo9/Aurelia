using Aurelia.API.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aurelia.API.Repository.Interfaces
{
    public interface IFormRepository
    {
        void AddForm(Form form);

        void DeleteForm(int id);

        List<Form> GetAllForms();

        Form GetFormById(int id);

        void UpdateForm(Form form);
    }
}
