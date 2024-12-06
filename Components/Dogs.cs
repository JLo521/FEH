

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

        public Dogs()
        {
            Id = 0;
            AdoptionPending = false;
            Age = 1;
            Name = null;
            Size = 0;
            Description = null;
            Breed = null;
            Image = null;
        }
        public Dogs(int id, bool adoptionPending, int age, string name, decimal size, string description, string breed, string image)
        {
            Id = id;
            AdoptionPending = adoptionPending;
            Age = age;
            Name = name;
            Size = size;
            Description = description;
            Breed = breed;
            Image = image;
        }



    }

}

