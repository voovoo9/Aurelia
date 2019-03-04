using Aurelia.API.Business.Interfaces;
using Aurelia.API.Entities;
using Aurelia.API.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aurelia.API.Business
{
    public class FormManager : IFormManager
    {
        IFormRepository _formRepository;

        public FormManager(IFormRepository formRepository)
        {
            _formRepository = formRepository;
        }

        public void AddForm(Form form)
        {
            _formRepository.AddForm(form);
        }

        public void DeleteForm(int id)
        {
            _formRepository.DeleteForm(id);
        }

        public List<Form> GetAllForms()
        {
            return _formRepository.GetAllForms();
        }

        public Form GetFormById(int id)
        {
            return _formRepository.GetFormById(id);
        }

        public void UpdateForm(int id, Form form)
        {
            _formRepository.UpdateForm(id, form);
        }
    }
}
