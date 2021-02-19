using System;
using System.Collections.Generic;
using System.Data;
using allSpice.Models;

namespace allSpice.Repositories
{
  public class RecipesRepository
  {
      private readonly IDbConnection _db;
      public RecipesRepository(IDbConnection db)
      {
          _db = db;
      }

    internal IEnumerable<Recipe> GetAll()
    {
      throw new NotImplementedException();
    }

    internal Recipe GetById(int id)
    {
      throw new NotImplementedException();
    }

    internal Recipe Create(Recipe newRecipe)
    {
      throw new NotImplementedException();
    }

    internal Recipe Edit(Recipe updatedRecipe)
    {
      throw new NotImplementedException();
    }

    internal void Delete(Recipe data)
    {
      throw new NotImplementedException();
    }
  }
}