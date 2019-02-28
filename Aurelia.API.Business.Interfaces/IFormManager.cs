using Aurelia.API.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aurelia.API.Business.Interfaces
{
    public interface IFormManager
    {
        void AddForm(Form form);

        void DeleteForm(int id);

        List<Form> GetAllForms();

        Form GetFormById(int id);

        void UpdateForm(Form form);
    }
}
