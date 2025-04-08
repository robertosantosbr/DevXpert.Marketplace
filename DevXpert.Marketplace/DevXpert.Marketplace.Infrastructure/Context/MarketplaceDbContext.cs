using Microsoft.EntityFrameworkCore;

namespace DevXpert.Marketplace.Infrastructure.Context;

public partial class MarketplaceDbContext : DbContext
{
    public MarketplaceDbContext(DbContextOptions<MarketplaceDbContext> options) : base(options) { }
}