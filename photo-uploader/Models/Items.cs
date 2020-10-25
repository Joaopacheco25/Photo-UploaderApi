namespace photo_uploader.Models
{
    public class Items
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ItemPhotos ItemPhotos { get; set; }
    }
}