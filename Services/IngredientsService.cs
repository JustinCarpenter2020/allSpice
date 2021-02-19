using System;
using System.Collections.Generic;
using allSpice.Models;
using allSpice.Repositories;

namespace allSpice.Services
{
  public class IngredientsService
  {
  private readonly IngredientsRepository _repo;
  public IngredientsService(IngredientsRepository repo)
  {
    _repo = repo;
  }

    internal object GetIngredientById(int id)
    {
      var data = _repo.GetById(id);
      if(data == null)
      {
        throw new SystemException("This id is invalid");
      }
      return data;
    }

    internal object CreateIngredient(Ingredient newIngredient)
    {
      return _repo.Create(newIngredient);
    }

    internal object EditIngredient(Ingredient updatedIngredient)
    {
      var data = GetIngredientById(updatedIngredient.Id);
      updatedIngredient.Quantity = updatedIngredient.Quantity != null ? updatedIngredient.Quantity : data.Quanity;
      updatedIngredient.Title = updatedIngredient.Title != null ? updatedIngredient.Title : data.Title;
      updatedIngredient.Description = updatedIngredient.Description != null ? updatedIngredient.Description : data.Description;

      return _repo.Edit(updatedIngredient);
    }

    internal string DeleteIngredient(int id)
    {
      GetIngredientById(id);
      _repo.Delete(id);
      return "Deleted";
    }

    internal IEnumerable<Recipe> GetIngredients(int id)
    {
        IEnumerable<Recipe> data = _repo.GetByRecipeId(id);
      return data;
    }
  }
}