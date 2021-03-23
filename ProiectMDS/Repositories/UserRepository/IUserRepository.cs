using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFA.Models;

namespace MFA.Repositories.UserRepository
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User Get(int Id);
        User Create(User User);
        User Update(User User);
        User Delete(User User);
    }
}
