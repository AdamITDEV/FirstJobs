// Domain/Phones/Phone.cs
using Abp.Domain.Entities.Auditing;

namespace FirstJobs.Phones
{
    public class Phone : FullAuditedEntity<int>
    {
        public string Name { get; set; }           // ex: iPhone 15
        public string Brand { get; set; }          // ex: Apple
        public decimal Price { get; set; }         // ex: 25990000
        public int Stock { get; set; }             // tồn kho
        public string ImageUrl { get; set; }       // ảnh sản phẩm
    }
}
