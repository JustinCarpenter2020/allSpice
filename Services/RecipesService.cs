using System;
using System.Collections.Generic;
using allSpice.Models;
using allSpice.Repositories;

namespace allSpice.Services
{
  public class RecipesService
  {
    private readonly RecipesRepository _repo;
    public RecipesService(RecipesRepository repo)
    {
      _repo = repo;
    }
    internal IEnumerable<Recipe> GetAll()
    {
      return _repo.GetAll();
    }

    internal Recipe GetById(int id)
    {
      Recipe data = _repo.GetById(id);
      if(data == null)
      {
        throw new SystemException("invalid id");
      }
      return data;
    }

    internal Recipe CreateRecipe(Recipe newRecipe)
    {
      return _repo.Create(newRecipe);
    }

    internal Recipe EditRecipe(Recipe updatedRecipe)
    {
      Recipe data = GetById(updatedRecipe.Id);
      updatedRecipe.Description = updatedRecipe.Description != null ? updatedRecipe.Description : data.Description;
      updatedRecipe.Title = updatedRecipe.Title != null ? updatedRecipe.Title : data.Title;
      updatedRecipe.PrepTime = updatedRecipe.PrepTime != 0 ? updatedRecipe.PrepTime : data.PrepTime;

      return _repo.Edit(updatedRecipe);
    }

    internal string DeleteRecipe(int id)
    {
      Recipe data = GetById(id);
      _repo.Delete(data);
      return "Deleted";
    }
  }
}