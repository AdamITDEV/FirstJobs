// src/FirstJobs.Application/Contacts/Dto/ContactDto.cs
using Abp.Application.Services.Dto;
namespace FirstJobs.Contacts.Dto
{
    public class ContactDto : EntityDto<int>
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
