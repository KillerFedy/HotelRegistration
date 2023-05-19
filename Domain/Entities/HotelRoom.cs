using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class HotelRoom
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public int NumberOfSeats { get; set; }
        public int CostPerDay { get; set; }
        public ICollection<Guest> Guests { get; set; } = new List<Guest>();
        public RoomType Type { get; set; }
    }
}
