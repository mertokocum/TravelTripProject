﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Comments
    {
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Mail { get; set; }
        public string Comment { get; set; }
        public int  Blogid { get; set; }
        public virtual Blog Blog { get; set; }         //blog tablosundan deger turetme

    }
}