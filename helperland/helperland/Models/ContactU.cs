using System;
using System.Collections.Generic;

namespace helperland.Models
{
    public partial class ContactU
    {
        public int ContactUsId { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Subject { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public string Message { get; set; } = null!;
        public string? UploadFileName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? Status { get; set; }
        public int? Priority { get; set; }
        public int? AssignedToUser { get; set; }
        public bool IsDeleted { get; set; }
    }
}
