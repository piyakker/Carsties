using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;

public class AuctionDbContext : DbContext
{
    public AuctionDbContext(DbContextOptions options) : base(options)
    {
    }

    // no need to add Item to DbSet because of 1:1 relationship, but remember to specify table name in plural!
    public DbSet<Auction> Auctions { get; set; }
}
