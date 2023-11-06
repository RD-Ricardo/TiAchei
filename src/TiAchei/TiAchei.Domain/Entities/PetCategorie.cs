using TiAchei.Core.DomainObjects;

namespace TiAchei.Domain.Entities
{
    public class PetCategorie : Entity, IAggregateRoot
    {
        public string  Name { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
