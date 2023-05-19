using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IGuestRepository
    {
        public Guest GetGuestById(int id);
        public Guest AddGuest(Guest guest, int roomId);
        public Guest UpdateGuest(Guest guest);
        public Guest ChangeGuestRoom(Guest guest, int roomId);
        public Guest DeleteGuest(int id);
        public List<Guest> GetAll();
    }
}
