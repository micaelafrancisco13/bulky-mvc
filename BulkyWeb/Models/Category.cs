using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models;

public class Category
{
    // primary key
    // [Key] is not required if key's name is Id or CategoryId
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public int DisplayOrder { get; set; }
}