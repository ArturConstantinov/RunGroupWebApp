﻿using RunGroupWebApp.Models;

namespace RunGroupWebApp.Interfaces
{
    public interface IDashboardRepository
    {
        Task<List<Race>> GetAllUserRaces();
        Task<List<Club>> GetAllUserClubs();
        Task<AppUser> GetUserById(string id);
        Task<AppUser> GetUserByIdNoTraking(string id);
        bool Update(AppUser user);
        bool Save();
    }
}
