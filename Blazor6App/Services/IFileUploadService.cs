using Microsoft.AspNetCore.Components.Forms;

namespace Blazor6App.Services
{
    public interface IFileUploadService
    {
        Task UploadFile(IBrowserFile file);
    }

    public class FileUploadService : IFileUploadService
    {
        private IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<FileUploadService> _logger;

        public FileUploadService(IWebHostEnvironment webHostEnvironment, 
            ILogger<FileUploadService> logger)
        {
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;
        }

        public async Task UploadFile(IBrowserFile file)
        {
            if(file is not null)
            {
                try
                {
                    var uploadPath = Path.Combine(_webHostEnvironment.WebRootPath,
                        "uploads", file.Name);
                    
                    using(var stream = file.OpenReadStream())
                    {
                        var fileStream = File.Create(uploadPath);
                        await stream.CopyToAsync(fileStream);
                        fileStream.Close();
                    }
                }
                catch (Exception e)
                {

                    _logger.LogError(e.ToString());
                }
            }
        }
    }
}
