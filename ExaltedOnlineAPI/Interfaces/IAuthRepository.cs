using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExaltedOnlineAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExaltedOnlineAPI.Interfaces
{
    public interface IAuthRepository
    {
        Task<Users> Register(Users user, string password);
        Task<Users> Login(string username, string pasword);
        Task<bool> UserExists(string username);
        Task<Users> GetUsersAsync(Users entity);
    }
}
