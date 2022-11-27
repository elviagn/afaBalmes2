using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using afaBalmes2.Data;
using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace afaBalmes2.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new afaBalmes2Context(
                   serviceProvider.GetRequiredService<
                       DbContextOptions<afaBalmes2Context>>()))
        {
            if (context.User.Any())
            {
                return;   // DB has been seeded
            }
            context.User.AddRange(
                new User
                {
                    Email = "elviagn@gmail.com",
                    Password = Encrypt.GetMD5("admin"),
                    Date = DateTime.UtcNow,
                    Role = UserRole.Write,
                    Status = Status.Active
                }
            );
            context.SaveChanges();
        }
    }
}