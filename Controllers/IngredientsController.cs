using allSpice.Models;
using allSpice.Services;
using Microsoft.AspNetCore.Mvc;

namespace allSpice.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
    public class IngredientsController : ControllerBase
    {
        private readonly IngredientsService _service;
        public IngredientsController(IngredientsService service)
        {
            _service = service;
        }
        [HttpGet("{id}")]
        public ActionResult<Ingredient> getIngredientById(int id)
        {
            try
            {
                return Ok(_service.GetIngredientById(id));
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpPost]
        public ActionResult<Ingredient> CreateIngredient([FromBody] Ingredient newIngredient)
        {
            try
            {
                return Ok(_service.CreateIngredient(newIngredient));
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Ingredient> EditIngredient([FromBody] Ingredient updatedIngredient, int id)
        {
            try
            {
                updatedIngredient.Id = id;
                return Ok(_service.EditIngredient(updatedIngredient));
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<string> DeleteIngredient(int id)
        {
            try
            {
                _service.DeleteIngredient(id);
                return Ok("Successfully removed")
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }








    }
}