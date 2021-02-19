using System.Collections.Generic;
using allSpice.Models;
using allSpice.Services;
using Microsoft.AspNetCore.Mvc;

namespace allSpice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipesController: ControllerBase
    {
        private readonly RecipesService _service;
         private readonly IngredientsService _ingredientsService;
        public RecipesController(RecipesService service, IngredientsService ingredientsService)
        {
            _service = service;
            _ingredientsService = ingredientsService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Recipe>> Get()
        {
            try
            {
                return Ok(_service.GetAll());
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Recipe> GetById(int id)
        {
            try
            {
                return Ok(_service.GetById(id));
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpGet("{id}/ingredients")]
        public ActionResult<IEnumerable<Ingredient>> GetIngredients(int id)
        {
            try
            {
                 IEnumerable<Recipe> data = _ingredientsService.GetIngredients(id);
                return Ok(data)
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpPost]
        public ActionResult<Recipe> CreateRecipe([FromBody] Recipe newRecipe)
        {
            try
            {
                return Ok(_service.CreateRecipe(newRecipe));
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Recipe> EditRecipe([FromBody] Recipe updatedRecipe, int id)
        {
            try
            {
                updatedRecipe.Id = id;
                return Ok(_service.EditRecipe(updatedRecipe));
            }
            catch (System.Exception err)
            {
                
               return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<string> DeleteRecipe(int id)
        {
            try
            {
                _service.DeleteRecipe(id);
                return Ok("successfully deleted");
            }
            catch (System.Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }






    }
}