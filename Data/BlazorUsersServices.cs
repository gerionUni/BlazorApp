using BlazorApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class BlazorUsersServices
{
    #region Private members
    private BlazorUsersDbContext dbContext;
    #endregion

    #region Constructor
    public BlazorUsersServices(BlazorUsersDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    #endregion

    #region Public methods
    /// <summary>
    /// This method returns the list of blazorUsers
    /// </summary>
    /// <returns></returns>
    public async Task<List<BlazorUser>> GetBlazorUsersAsync()
    {
        return await dbContext.BlazorUser.ToListAsync();
    }

    /// <summary>
    /// This method add a new blazorUsers to the DbContext and saves it
    /// </summary>
    /// <param name="blazorUsers"></param>
    /// <returns></returns>
    public async Task<BlazorUser> AddBlazorUsersAsync(BlazorUser blazorUser)
    {
        try
        {
            dbContext.BlazorUser.Add(blazorUser);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return blazorUser;
    }

    /// <summary>
    /// This method update and existing blazorUsers and saves the changes
    /// </summary>
    /// <param name="blazorUsers"></param>
    /// <returns></returns>
    public async Task<BlazorUser> UpdateBlazorUsersAsync(BlazorUser blazorUser)
    {
        try
        {
            var productExist = dbContext.BlazorUser.FirstOrDefault(p => p.Name == blazorUser.Name);
            if (productExist != null)
            {
                dbContext.Update(blazorUser);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return blazorUser;
    }

    /// <summary>
    /// This method removes and existing blazorUsers from the DbContext and saves it
    /// </summary>
    /// <param name="blazorUser"></param>
    /// <returns></returns>
    public async Task DeleteBlazorUserAsync(BlazorUser blazorUser)
    {
        try
        {
            dbContext.BlazorUser.Remove(blazorUser);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}