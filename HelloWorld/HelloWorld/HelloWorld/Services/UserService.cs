using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld.Services
{
    public class UserService
    {
        private List<User> _users = new List<User>
        {
            new User { Id = 1, Description = "My name is Jenny Dalby", Name = "Jenny Dalby", ImageUrl="https://imgc.allpostersimages.com/img/print/posters/the-avengers-age-of-ultron-hulk_a-G-13760181-4985772.jpg" },
            new User { Id = 2, Description = "My name is Jonv", Name = "Jonv", ImageUrl="https://lumiere-a.akamaihd.net/v1/images/usa_spider-man_chi_spider-man_r_d909a17b.png?region=0%2C0%2C600%2C600" },
            new User { Id = 3, Description = "My name is RachelMartin", Name = "RachelMartin" , ImageUrl="https://imgc.allpostersimages.com/img/print/posters/the-avengers-age-of-ultron-hulk_a-G-13760181-4985772.jpg" },
            new User { Id = 4, Description = "My name is Nivan Jay", Name = "Nivan Jay", ImageUrl="https://lumiere-a.akamaihd.net/v1/images/usa_spider-man_chi_spider-man_r_d909a17b.png?region=0%2C0%2C600%2C600" },
            new User { Id = 5, Description = "My name is SanazZ", Name = "SanazZ" , ImageUrl="https://imgc.allpostersimages.com/img/print/posters/the-avengers-age-of-ultron-hulk_a-G-13760181-4985772.jpg" },
            new User { Id = 6, Description = "My name is NextLab", Name = "NextLab", ImageUrl="https://lumiere-a.akamaihd.net/v1/images/usa_spider-man_chi_spider-man_r_d909a17b.png?region=0%2C0%2C600%2C600" },
            new User { Id = 7, Description = "My name is Alex B", Name = "AlexB" , ImageUrl="https://imgc.allpostersimages.com/img/print/posters/the-avengers-age-of-ultron-hulk_a-G-13760181-4985772.jpg" },
            new User { Id = 8, Description = "My name is Tara Chang", Name = "Tara Chang", ImageUrl="https://lumiere-a.akamaihd.net/v1/images/usa_spider-man_chi_spider-man_r_d909a17b.png?region=0%2C0%2C600%2C600" },
            new User { Id = 9, Description = "My name is TomK", Name = "Tom K", ImageUrl="https://imgc.allpostersimages.com/img/print/posters/the-avengers-age-of-ultron-hulk_a-G-13760181-4985772.jpg"  },
        };

        public User GetUser(int userId)
        {
            return _users.SingleOrDefault(u => u.Id == userId);
        }
    }
}
