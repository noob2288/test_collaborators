using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var users = new List<AppUser>()
            {
                new() { Id = 1, UserName = "User1" },
                new() { Id = 2, UserName = "User2" },
                new() { Id = 3, UserName = "User3" },
                new() { Id = 4, UserName = "User4" },
                new() { Id = 5, UserName = "User5" },
            };
            builder.HasData(users);
        }
    }
}
