using System.Diagnostics;
using System.Reflection;

namespace dotnetapp.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Recipe> Recipes {get;set;}
    }
}