using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmRoller
{
    public class Film
    {
        int FilmId { get; set; }
        int FilmName { get; set; }
        int FilmOwner { get; set; }
    }
    public class Owner
    {
        int OwnerId { get; set; }
        string OwnerName { get; set; }
    }

    public class Review
    {
        int ReviewId { get; set; }
        int FilmId { get; set; }
        int OwnerId { get; set; }
        DateTime ReviewDate { get; set; }
    }
}
