using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IHotelRoomRepository
    {
        public HotelRoom GetById(int id);
        public HotelRoom AddRoom(HotelRoom hotelRoom);
        public HotelRoom UpdateRoom(HotelRoom hotelRoom);
        public HotelRoom DeleteRoom(int id);
        public List<HotelRoom> FindAll();
        public List<HotelRoom> GetByType(RoomType roomType);
    }
}
