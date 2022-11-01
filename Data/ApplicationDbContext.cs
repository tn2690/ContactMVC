﻿using ContactMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ContactMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // interact with database
        public virtual DbSet<Contact> Contacts { get; set; } = default!;

        public virtual DbSet<Category> Categories { get; set; } = default!;
    }
}