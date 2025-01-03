using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(new Product { Id = 1, Name = "Paçoca" });
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            return Ok(new Product { Id = id, Name = "Paçoca" });
        }

        [HttpPost]
        [ProducesResponseType(typeof(Product),StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post(Product product)
        {
            return CreatedAtAction("Get", new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Put(int id, Product product)
        {
            if (id != product.Id) return BadRequest();
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult Delete(int id)
        {
            if (id == 0) return NotFound();
            return NoContent();
        }
    }
}
