﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelTripProject.Models.Classes
{
    public class Context : DbContext //el ile eklendi
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<AboutMe> AboutMes { get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Comments> CommentsS { get; set; }
        public DbSet<AvatarImageUrl> AvatarImageUrls { get; set; }


    }
}