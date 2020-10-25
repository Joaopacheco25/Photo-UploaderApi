using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using photo_uploader.Models;
using photo_uploader.Services;
using photo_uploader.Utils;

namespace photo_uploader.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class PhotoUploaderController : ControllerBase
    {
        private readonly IPhotoUploaderService _photoUploaderService;
        private readonly ILogger _logger;
        public PhotoUploaderController(IPhotoUploaderService photoUploaderService, ILogger logger)
        {
            _photoUploaderService = photoUploaderService;
            _logger = logger;
        }
        
        [HttpPost("addPhoto")]
        public async Task<IActionResult> PostPhoto([FromBody] ItemPhotos photo )
        {
            try
            {
                (photo != null).EntityHandleException();
                await _photoUploaderService.AddOurUpdatePhotoAsync(photo);
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                
                return BadRequest();;
            }
        }
    }
}