using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aurelia.API.Business.Interfaces;
using Aurelia.API.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [DisableCors]
    public class FormController : ControllerBase
    {
        private readonly IFormManager _formManager;

        public FormController(IFormManager formManager)
        {
            _formManager = formManager;
        }


        // GET: api/Form
        [HttpGet]
        public IActionResult Get()
        {
            var result = _formManager.GetAllForms();
            return Ok(result);
        }

        // GET: api/Form/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _formManager.GetFormById(id);

            if (result == null)
                return NotFound();
            return Ok(result);
        }

        // POST: api/Form
        [HttpPost]
        public IActionResult Post([FromBody] Form form)
        {
            if (ModelState.IsValid)
            {
                _formManager.AddForm(form);
                return this.Ok(form);
            }
            else return this.StatusCode(StatusCodes.Status422UnprocessableEntity);
        }

        // PUT: api/Form/5
        [HttpPut("edit/{id}")]
        public IActionResult Put(int id, [FromBody] Form form)
        {
            if (ModelState.IsValid)
            {
                _formManager.UpdateForm(id, form);
                return this.Ok(form);
            }
            else return this.StatusCode(StatusCodes.Status422UnprocessableEntity);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _formManager.GetFormById(id);
            if(deleted == null)
            {
                return NotFound();
            }
            _formManager.DeleteForm(id);
            return Ok();
        }


        //****Proba****
        //[HttpGet]
        //public object Get()
        //{
        //    return new { Email = "masdfmds", Id = 1, FirstName = "msedfcm", LastName = "mdfms" };
        //}
    }
}
