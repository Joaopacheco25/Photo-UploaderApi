using System;
using System.Collections.Generic;

namespace photo_uploader.Models
{
    public class TypePropertySet
    {
        public int Id { get; set; }
        public int MediaTypeId { get; set; }
        public int PropertyId { get; set; }

        public Type Type { get; set; }
        public Properties Property { get; set; }

        public Items Item { get; set; }
    }
}