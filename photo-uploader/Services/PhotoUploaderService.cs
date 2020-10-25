using System.Threading.Tasks;
using photo_uploader.Models;
using photo_uploader.Repository;

namespace photo_uploader.Services
{
    public class PhotoUploaderService :IPhotoUploaderService
    {
        private readonly IPhotoUploaderRepository _photoUploaderRepository;
        
        public PhotoUploaderService(IPhotoUploaderRepository photoUploaderRepository)
        {
            _photoUploaderRepository = photoUploaderRepository;
        }

        public async  Task<ItemPhotos> AddOurUpdatePhotoAsync(ItemPhotos itemPhoto)
        {
            return await  _photoUploaderRepository.AddOurUpdatePhotoAsync(itemPhoto);
        }

        public Task<ItemPhotos> GetPhotoById(int id)
        {
            return _photoUploaderRepository.GetItemPhotoAsync(id);
        }
    }
}