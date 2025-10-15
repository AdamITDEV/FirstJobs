// src/FirstJobs.Application/Contacts/Dto/UpdateContactDto.cs
using Abp.Application.Services.Dto;
namespace FirstJobs.Contacts.Dto
{
    public class UpdateContactDto : EntityDto<int>
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
