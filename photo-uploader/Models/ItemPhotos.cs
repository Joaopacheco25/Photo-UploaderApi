using System;

namespace photo_uploader.Models
{
    public class ItemPhotos
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int TypeId { get; set; }
        public string FileName { get; set; }
        public int Position { get; set; }
        public string Alt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool  IsActive { get; set; }

        public Items Item { get; set; }
        
        public Types type  { get; set; }
    }
}
