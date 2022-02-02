using System;
using System.Collections.Generic;

namespace helperland.Models
{
    public partial class ContactUsAttachment
    {
        public int ContactUsAttachmentId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] FileName { get; set; } = null!;
    }
}
