﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class AvatarImageUrl
    {
        [Key]
        public int ID { get; set; }
        public string ImageUrl { get; set; }
    }
}