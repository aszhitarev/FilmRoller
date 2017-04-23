using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmRoller
{
    public class Film
    {
        public int FilmId { get; set; }
        public int FilmName { get; set; }
        public int FilmOwner { get; set; }
    }
    public class Owner
    {
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
    }

    public class Review
    {
        public int ReviewId { get; set; }
        public int FilmId { get; set; }
        public int OwnerId { get; set; }
        public DateTime ReviewDate { get; set; }
        public virtual ICollection<Owner> Owner { get; set; }
        public virtual ICollection<Film> Film { get; set; }

    }
}
