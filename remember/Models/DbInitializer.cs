using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace remember.Models
{
    public static class DbInitializer
    {
        public static void Seed( AppDbContext context) {
            if (context.Noodles.Any()) {
                return;
            }

            context.AddRange(
                new Noodle { Name = "牛肉面", Price = 12, ShortDescription="小分牛肉拉面" },
                new Noodle { Name = "大份牛肉面", Price = 15, ShortDescription = "大分牛肉拉面" },
                new Noodle { Name = "番茄鸡蛋面", Price = 12, ShortDescription = "新鲜的番茄" }
             );

            context.SaveChanges();
        }
    }
}
