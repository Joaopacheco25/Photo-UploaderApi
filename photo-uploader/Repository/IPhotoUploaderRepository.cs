using System.Threading.Tasks;
using photo_uploader.Models;

namespace photo_uploader.Repository
{
    public interface  IPhotoUploaderRepository
    {
        Task<ItemPhotos> AddOurUpdatePhotoAsync(ItemPhotos itemPhoto);

        Task<ItemPhotos> GetItemPhotoAsync(int id);
    }
}