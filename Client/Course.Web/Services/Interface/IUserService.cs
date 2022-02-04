using Course.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Web.Services.Interface
{
    public interface IUserService
    {
        Task<UserViewModel> GetUser();
    }
}
