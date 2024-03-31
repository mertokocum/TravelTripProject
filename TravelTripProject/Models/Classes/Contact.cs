﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }
        public string NameSurname { get; set; }
        public string Mail { get; set; }
        public string Topic { get; set; }
        public string Message { get; set; }

    }
}