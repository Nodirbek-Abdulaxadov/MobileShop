using MobileShop.Data;
using MobileShop.Domain;

namespace MobileShop.Website.Services
{
    public class FileRepository : IFileInterface
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IWebHostEnvironment _environment;

        public FileRepository(ApplicationDbContext dbContext,
                              IWebHostEnvironment environment)
        {
            _dbContext = dbContext;
            _environment = environment;
        }
        public void DeleteFile(string path)
        {
            throw new NotImplementedException();
        }

        public List<ImageModel> GetImages(Guid id)
        {
            return _dbContext.Images.Where(image => image.ProductId == id).ToList();
        }

        public ImageModel SaveImages(IFormFile file)
        {  
            string uniqueName = String.Empty;
            if (file != null)
            {
                string uplodFolder = Path.Combine(_environment.WebRootPath, "images");
                uniqueName = Guid.NewGuid().ToString() + "_" + file.FileName;
                string filePath = Path.Combine(uplodFolder, uniqueName);
                FileStream fileStream = new FileStream(filePath, FileMode.Create);
                file.CopyTo(fileStream);
                fileStream.Close();

                ImageModel model = new ImageModel();
                model.Id = Guid.NewGuid();
                model.Path = uniqueName;
                model.ProductId = Guid.NewGuid();

                _dbContext.Images.Add(model);
                _dbContext.SaveChanges();

                return model;
            }

            return null;
        }
    }
}
