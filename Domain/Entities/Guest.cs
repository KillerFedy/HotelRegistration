﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Guest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PassportSeries { get; set; }
        public int PassportNumber { get; set; }

        [Required]
        public HotelRoom HotelRoom { get; set; }
    }
}