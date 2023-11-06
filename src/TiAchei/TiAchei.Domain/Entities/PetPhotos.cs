using System.ComponentModel;
using TiAchei.Core.DomainObjects;

namespace TiAchei.Domain.Entities
{
    public class PetPhotos : Entity
    {
        public int PetId { get; set; }
        public Pet Pet { get; set; }
    }
}
