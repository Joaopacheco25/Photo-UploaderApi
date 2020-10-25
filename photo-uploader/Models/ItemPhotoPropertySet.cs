namespace photo_uploader.Models
{
    public class ItemPhotoPropertySet
    {
        public int Id { get; set; }
        public int ItemPhotoId { get; set; }
        public int ProductId { get; set; }
        public string  Value { get; set; }
    }
}