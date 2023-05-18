using Microsoft.EntityFrameworkCore;
using CarConnectAPI.Models;

namespace CarConnectAPI.Data
{
    // All he needs to do is inherit from the DbContext class, 
    // which is part of the EntityFrameworkCore library.
    public class AppDbContext : DbContext
    {
        // This class is the application's data context.
        // Data context is the representation of the database in memory.

        // DbSet<CarConnect> é representação da tabela
        public DbSet<CarConnect> CarConnects { get; set; }
    }
}