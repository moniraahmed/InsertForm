using InsertForm.Data;
using InsertForm.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace InsertForm.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InsertController : ControllerBase
    {
        private readonly IAddFormService _addForm;
        public InsertController(IAddFormService addForm)
        {
           _addForm= addForm;
        }

        [HttpPost]
        public IActionResult Insert(UserForm newForm)
        {
            if(newForm != null)
            {
                _addForm.AddNewForm(newForm);
            }
            return Ok(newForm);
        }
    }
}
