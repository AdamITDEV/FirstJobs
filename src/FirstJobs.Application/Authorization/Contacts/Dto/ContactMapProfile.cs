// src/FirstJobs.Application/Contacts/Dto/ContactMapProfile.cs
using AutoMapper;
namespace FirstJobs.Contacts.Dto
{
    public class ContactMapProfile : Profile
    {
        public ContactMapProfile()
        {
            CreateMap<Contact, ContactDto>();
            CreateMap<CreateContactDto, Contact>();
            CreateMap<UpdateContactDto, Contact>();
        }
    }
}
