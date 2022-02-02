using helperland.Models;
using helperland.ViewModels;

namespace helperland.Repository
{
    public class ContactRepository
    {
        private readonly HelperlandContext _context;
        public ContactRepository(HelperlandContext context)
        {
                _context = context;
        }
        public int Contact(ContactViewModel model)
        {
            var newContact = new ContactU()
            {
                Name = model.Name,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                Subject = model.Subject,
                Message = model.Message,
            };
            _context.ContactUs.Add(newContact);
            _context.SaveChanges();
            return newContact.ContactUsId;
        }
    }
}
