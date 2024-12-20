using System.Runtime.Serialization;

namespace FEH.Components
{
    public class Dogs
    {
        public int Id { get; set; }
        public bool AdoptionPending { get; set; }
        public int Age { get; set; }
        public string? Name { get; set; }
        public decimal Size { get; set; }
        public string? Description { get; set; }
        public string? Breed { get; set; }
        public string? Image { get; set; }


        /*public Dogs()
        {
            Id = 0;
            AdoptionPending = false;
            Age = 1;
            Name = null;
            Size = 0;
            Description = null;
            Breed = null;
            Image = null;

        }*/
    }
}




