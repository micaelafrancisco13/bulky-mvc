using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    // creates a category table
    // type is the table name
    public DbSet<Category> Categories { get; set; }
}