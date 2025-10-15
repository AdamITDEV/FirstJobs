// src/FirstJobs.Web.Mvc/Models/Contacts/ContactEditViewModel.cs
namespace FirstJobs.Web.Models.Contacts
{
    public class ContactEditViewModel
    {
        public int? Id { get; set; }            // null => create
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
