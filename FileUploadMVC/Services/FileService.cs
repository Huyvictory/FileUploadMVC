using FileUploadMVC.Data;
using FileUploadMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FileUploadMVC.Services
{
    public class FileService
    {
        public async Task<FileUploadViewModel> LoadAllFiles(ApplicationDbContext context)
        {
            var viewModel = new FileUploadViewModel();
            viewModel.FilesOnDatabase = await context.FileOnDatabase.ToListAsync();
            viewModel.FilesOnFileSystem = await context.FilesOnSystem.ToListAsync();
            return viewModel;
        }
    }
}
