using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using photo_uploader.Models;

namespace photo_uploader.Repository
{
    public class PhotoUploaderRepository :IPhotoUploaderRepository
    {
        private readonly PhotoUploaderDbContext _dbContext;
        
        public PhotoUploaderRepository(PhotoUploaderDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<ItemPhotos> AddOurUpdatePhotoAsync(ItemPhotos entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity must not be null");
            }
            try
            {
                await _dbContext.AddAsync(entity);
                await _dbContext.SaveChangesAsync();
                return entity;
            }
            catch (Exception e)
            {
                throw new Exception($"{nameof(entity)} could not be saved: {e.Message}");
            }
        }
        
        public Task<ItemPhotos> GetItemPhotoAsync(int id)
        {
            return _dbContext.ItemPhotos
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}