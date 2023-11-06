using TiAchei.Core.DomainObjects;

namespace TiAchei.Domain.Entities
{
    public class Pet : Entity, IAggregateRoot
    {
        public string Name { get; private set; }
        public int Agent { get; private set; }
        public ICollection<PetPhotos> PetPhotos { get; private set; }

        //EF 
        public int  UserId { get; private set; }
        public User User { get; private set; }
        public int PetCagorieId { get; private set; }
        public PetCategorie PetCategorie { get; private set; }
        
        public Pet(string name, int agent, ICollection<PetPhotos> petPhotos, int userId, int petCategorieId)
        {
            Name = name;
            Agent = agent;
            UserId = userId;
            PetPhotos = petPhotos;
            PetCagorieId = petCategorieId;
        }

        public void AddPhoto(PetPhotos petPhotos)
        {
            PetPhotos.Add(petPhotos);
        }
       
    }
}
