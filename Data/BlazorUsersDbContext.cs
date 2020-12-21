using BlazorApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class BlazorUsersDbContext : DbContext
{
    #region Contructor
    public BlazorUsersDbContext(DbContextOptions<BlazorUsersDbContext> options)
            : base(options)
    {

    }
    #endregion

    #region Public properties
    public DbSet<BlazorUser> BlazorUser { get; set; }
    #endregion

    #region Overidden methods
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BlazorUser>().HasKey(x => x.Name);
        modelBuilder.Entity<BlazorUser>().HasData(GetProducts());
        base.OnModelCreating(modelBuilder);
    }
    #endregion


    #region Private methods
    private List<BlazorUser> GetProducts()
    {
        return new List<BlazorUser>
    {
        new BlazorUser { Name = "NewUser", Email = "NewUser@gmail.com", Phone_Number="0711111111", Domain ="gmail.com",Notes=" first blazor app"},
        new BlazorUser { Name = "NewUser2", Email = "NewUser2@gmail.com", Phone_Number="0711111112", Domain ="gmail.com",Notes=" first blazor app"},
        new BlazorUser { Name = "NewUser3", Email = "NewUser3@gmail.com", Phone_Number="0711111113", Domain ="gmail.com",Notes=" first blazor app"},
        new BlazorUser { Name = "NewUser4", Email = "NewUser4@gmail.com", Phone_Number="0711111114", Domain ="gmail.com",Notes=" first blazor app"}
    };
    }
    #endregion
}