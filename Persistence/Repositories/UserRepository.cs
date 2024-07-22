using CleanArchit.Domain.Entities;
using CleanArchit.Domain.Interfaces;
using CleanArchit.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchit.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<User> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return await Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
        }
    }
}
