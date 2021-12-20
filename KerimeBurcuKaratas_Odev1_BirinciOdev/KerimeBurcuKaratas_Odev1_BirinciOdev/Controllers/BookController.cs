using KerimeBurcuKaratas_Odev1_BirinciOdev.Data;
using KerimeBurcuKaratas_Odev1_BirinciOdev.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KerimeBurcuKaratas_Odev1_BirinciOdev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private static DemoDataService demoDataService = new DemoDataService();    

        public BookController()
        {
              
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            var result = demoDataService.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetByIdFromRoute/{id}")]
        public IActionResult GetByIdFromRoute([FromRoute] int id)
        {
            var result = demoDataService.GetById(id);
            return Ok(result);
        }
        
        
        [HttpGet]
        [Route("GetByIdFromQuery")]
        public IActionResult GetByIdFromQuery([FromQuery] int id)
        {
            var result = demoDataService.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Add([FromBody] Book book)
        {
            var result = demoDataService.Add(book);
            return Ok(result);
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromBody] Book book)
        {
            var result = demoDataService.UpDate(book);
            var message = result ? "Book updated." : "Book not update.";
            return Ok(message);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var result = demoDataService.Delete(id);
            var message = result ? "Book deleted." : "Book not delete.";
            return Ok(message);

        }

    }
}
