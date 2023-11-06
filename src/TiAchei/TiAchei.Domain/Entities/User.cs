using TiAchei.Core.DomainObjects;
using TiAchei.Core.DomainObjects.ValueObjects;

namespace TiAchei.Domain.Entities
{
    public class User : Entity, IAggregateRoot
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Email Email { get; private set; }
        public string Password { get; private set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
