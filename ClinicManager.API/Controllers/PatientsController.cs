using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManager.API.Controllers
{
    [Route("api/patients")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpGet("document/{document}")]
        public IActionResult GetByDocument(String document)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(TestClass testClass)
        {
            return CreatedAtAction(nameof(GetById), new { testClass.Id }, testClass);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, TestClass testClass)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
