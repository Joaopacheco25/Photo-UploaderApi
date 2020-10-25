using System.Threading.Tasks;
using photo_uploader.Models;

namespace photo_uploader.Services
{
    public interface  IPhotoUploaderService
    {
        Task<ItemPhotos> AddOurUpdatePhotoAsync(ItemPhotos itemPhoto);
        Task<ItemPhotos> GetPhotoById(int id);
    }
}