using Microsoft.AspNetCore.Identity;

namespace Horizons.Data.Models
{
    public class Destination
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string? ImageUrl { get; set; }

        public string PublisherId { get; set; } = null!;

        public virtual IdentityUser Publisher { get; set; } = null!;

        public DateTime PublishedOn { get; set; }

        public int TerrainId { get; set; }

        //navigation property
        public virtual Terrain Terrain { get; set; } = null!;

        public bool IsDeleted { get; set; }

        //navigation Collection
        public virtual ICollection<UserDestination> UsersDestinations { get; set; } = new HashSet<UserDestination>();
    }
}

/* Destination
•	Has Id – a unique integer, Primary Key
•	Has Name – a string with min length 3 and max length 80 (required)
•	Has Description – string with min length 10 and max length 250 (required)
•	Has ImageUrl – nullable string (not required)
•	Has PublisherId – string (required)
•	Has Publisher – IdentityUser (required)
•	Has PublishedOn – DateTime with format "dd-MM-yyyy" (required)
o	The DateTime format is only recommended
•	Has TerrainId – integer, foreign key (required)
•	Has Terrain – Terrain (required)
•	Has IsDeleted – bool (default value == false)
•	Has UsersDestinations – a collection of type UserDestination
*/