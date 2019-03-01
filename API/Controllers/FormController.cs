using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aurelia.API.Business.Interfaces;
using Aurelia.API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    //[Produces("api/json")] //da li je ispravno?
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        IFormManager _formManager;

        public FormController(IFormManager formManager)
        {
            _formManager = formManager;
        }


        // GET: api/Form
        [HttpGet]
        public List<Form> Get()
        {
            return _formManager.GetAllForms();
        }

        // GET: api/Form/5
        [HttpGet("{id}")]
        public Form Get(int id)
        {
            return _formManager.GetFormById(id);
        }

        // POST: api/Form
        [HttpPost]
        public void Post([FromBody] Form form)
        {
            _formManager.AddForm(form);
        }

        // PUT: api/Form/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Form form)
        {
            _formManager.UpdateForm(form);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _formManager.DeleteForm(id);
        }


        //****Proba****
        //[HttpGet]
        //public object Get()
        //{
        //    return new { Email = "masdfmds", Id = 1, FirstName = "msedfcm", LastName = "mdfms" };
        //}
    }
}
