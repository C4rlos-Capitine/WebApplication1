﻿using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
namespace WebApplication1
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Fornecedor> Produtos { get; set; }
    }

}
