namespace FileUploadMVC.Models
{
    public class FileUploadViewModel
    {
        public List<FileOnSystemModel> FilesOnFileSystem { get; set; }
        public List<FileOnDatabaseModel> FilesOnDatabase { get; set; }
    }
}
