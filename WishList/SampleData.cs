using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishList.Models;

namespace WishList
{
    public class SampleData
    {
        public static void Initialize(WishListContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        Id = 1,
                        Name = "Arman"
                    },
                    new User
                    {
                        Id = 2,
                        Name = "Bake"
                    },
                    new User
                    {
                        Id = 3,
                        Name = "Dake"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
