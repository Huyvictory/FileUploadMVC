using FileUploadMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FileUploadMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<FileOnSystemModel> FilesOnSystem { get; set; }
        public DbSet<FileOnDatabaseModel> FileOnDatabase { get; set; }
    }
}
