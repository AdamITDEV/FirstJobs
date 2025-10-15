// src/FirstJobs.Application/Contacts/IContactAppService.cs
using Abp.Application.Services;
using FirstJobs.Contacts.Dto;

namespace FirstJobs.Contacts
{
    public interface IContactAppService : IAsyncCrudAppService<
        ContactDto, int, PagedContactResultRequestDto, CreateContactDto, UpdateContactDto>
    { }
}
