namespace Horizons.Data.Models
{
    public class Terrain
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        //navigation collection
        public virtual ICollection<Destination> Destinations { get; set; } = new HashSet<Destination>();
    }
}

/* Terrain
•	Has Id – a unique integer, Primary Key
•	Has Name – a string with min length 3 and max length 20 (required)
•	Has Destinations – a collection of type Destination
*/
