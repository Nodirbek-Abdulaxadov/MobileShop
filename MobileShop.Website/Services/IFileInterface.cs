using MobileShop.Domain;

namespace MobileShop.Website.Services
{
    public interface IFileInterface
    {
        ImageModel SaveImages(IFormFile file);
        List<ImageModel> GetImages(Guid id);
        void DeleteFile(string path);
    }
}
