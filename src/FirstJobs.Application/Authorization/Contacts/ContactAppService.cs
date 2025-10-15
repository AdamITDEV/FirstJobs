// src/FirstJobs.Application/Contacts/ContactAppService.cs
using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using FirstJobs.Authorization;
using FirstJobs.Contacts.Dto;
using NuGet.Protocol.Core.Types;
using System.Linq;

namespace FirstJobs.Contacts
{
    [AbpAuthorize(PermissionNames.Pages_Contacts)]
    public class ContactAppService :
        AsyncCrudAppService<Contact, ContactDto, int, PagedContactResultRequestDto, CreateContactDto, UpdateContactDto>,
        IContactAppService
    {
        public ContactAppService(IRepository<Contact, int> repo) : base(repo) { }

        protected override IQueryable<Contact> CreateFilteredQuery(PagedContactResultRequestDto input)
            => Repository.GetAll()
               .WhereIf(!string.IsNullOrWhiteSpace(input.Keyword),
                        x => x.FullName.Contains(input.Keyword) || x.PhoneNumber.Contains(input.Keyword));

        protected override string CreatePermissionName => PermissionNames.Pages_Contacts_Create;
        protected override string UpdatePermissionName => PermissionNames.Pages_Contacts_Edit;
        protected override string DeletePermissionName => PermissionNames.Pages_Contacts_Delete;
    }
}
