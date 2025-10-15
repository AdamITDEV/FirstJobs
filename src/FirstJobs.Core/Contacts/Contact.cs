// src/FirstJobs.Core/Contacts/Contact.cs
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;

namespace FirstJobs.Contacts
{
    public class Contact : FullAuditedEntity<int>
    {
        [Required, StringLength(128)] public string FullName { get; set; }
        [Required, StringLength(32)] public string PhoneNumber { get; set; }
    }
}
