using System.ComponentModel.DataAnnotations;
namespace allSpice.Models
{
    public class Recipe
    {
    public string Title { get; set; }
        public string Description { get; set; }
        public int PrepTime { get; set; }

        public int Id { get; set; }
    }
}