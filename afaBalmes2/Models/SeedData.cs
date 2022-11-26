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
                    Date = DateTime.Now,
                    Role = UserRole.Read,
                    Status = Status.Pending
                }
            );
            context.SaveChanges();
        }
    }
}