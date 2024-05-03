using Microsoft.EntityFrameworkCore;
using Transport_Square.Models;

namespace Transport_Square.Data;

public class TransportSquareDbContext : DbContext
{
    //Shortcut: ctor
    public TransportSquareDbContext(DbContextOptions<TransportSquareDbContext> options) : base(options)
    {
        
    }

    public DbSet<UserViewModel> Users {get; set;}
}