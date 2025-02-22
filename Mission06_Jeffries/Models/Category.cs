using System.ComponentModel.DataAnnotations;
namespace Mission06_Jeffries.Models
{
    // Category class to make a new category table
    public class Category
    {
        [Key]
        public int? CategoryID { get; set; }
        public string? CategoryName { get; set; }

    }
}
