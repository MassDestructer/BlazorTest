using Demo.Company.Domain.Interfaces;

namespace Demo.Company.Domain.Entities
{
    public class Product : IBaseEntity
    {
        public int Id { get; set; }

        public required string Name { get; set; }
    }
}
