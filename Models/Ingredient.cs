namespace allSpice.Models
{
    public class Ingredient
    {
    public string Quantity { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public int Id { get; set; }

        public int RecipeId { get; set; }

        public Recipe Recipe { get; set; }
    }
}