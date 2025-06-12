using Microsoft.AspNetCore.Identity;

namespace Horizons.Data.Models
{
    public class UserDestination
    {
        public string UserId { get; set; } = null!;
        public virtual IdentityUser User { get; set; } = null!;
        public int DestinationId { get; set; }
        public virtual Destination Destination { get; set; } = null!;
    }
}

/* UserDestination
•	Has UserId – string, PrimaryKey, foreign key (required)
•	Has User – IdentityUser
•	Has DestinationId – integer, PrimaryKey, foreign key (required)
•	Has Destination – Destination
*/
