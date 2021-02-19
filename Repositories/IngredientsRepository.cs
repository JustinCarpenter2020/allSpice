using System;
using System.Collections.Generic;
using System.Data;
using allSpice.Models;

namespace allSpice.Repositories
{
  public class IngredientsRepository
  {
     private readonly IDbConnection _db;
      public IngredientsRepository(IDbConnection db)
      {
          _db = db;
      }
    internal Ingredient GetById(int id)
    {
      throw new NotImplementedException();
    }

    internal object Create(Ingredient newIngredient)
    {
      throw new NotImplementedException();
    }

    internal object Edit(Ingredient updatedIngredient)
    {
      throw new NotImplementedException();
    }

    internal IEnumerable<Recipe> GetByRecipeId(int id)
    {
      throw new NotImplementedException();
    }

    internal void Delete(int id)
    {
      throw new NotImplementedException();
    }
  }
}