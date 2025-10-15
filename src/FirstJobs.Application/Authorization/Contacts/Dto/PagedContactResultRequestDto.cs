// src/FirstJobs.Application/Contacts/Dto/PagedContactResultRequestDto.cs
using Abp.Application.Services.Dto;
namespace FirstJobs.Contacts.Dto
{
    public class PagedContactResultRequestDto : PagedAndSortedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
