using TiAchei.Core.DomainObjects;
using TiAchei.Domain.Enuns;

namespace TiAchei.Domain.Entities
{
    public class PetSituation : Entity
    {
        public string LinkAcessPet { get; set; }
        public Situation MyProperty { get; set; }
    }
}
