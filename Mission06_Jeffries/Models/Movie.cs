using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Mission06_Jeffries.Models
{
    public class Movie
    {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MovieId { get; set; }
    
    [ForeignKey("CategoryID")]
    public int? CategoryID { get; set; }
    public Category? Category { get; set; }

    [Required]
    public string Title { get; set; } //= string.Empty;

    [Required]
    [Range(1888,int.MaxValue)]
    public int Year { get; set; }

    public string? Director { get; set; }

    public string? Rating { get; set; }

    [Required]
    public bool Edited { get; set; }  
    public string? LentTo { get; set; }

    [Required]
    public bool CopiedToPlex { get; set; }

    [MaxLength(25)]
    public string? Notes { get; set; }
    }
}

