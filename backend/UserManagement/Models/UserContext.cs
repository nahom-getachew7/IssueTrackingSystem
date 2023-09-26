﻿using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace UserManagement.Models
{
    public class UserContext: DbContext
    {

        public UserContext(DbContextOptions<UserContext> options): base(options) 
        {

        }
		// public UserContext() { }
		public DbSet<User> Users { get; set; }
        public DbSet<Company> Company { get; set; }
    }
}
