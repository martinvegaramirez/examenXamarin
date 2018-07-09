
using System.Collections.Generic;

namespace examenXamarin.Models
{
    class User
    {
        public string imageUrl { get; set; }
        public string fullname { get; set; }
        public string rating { get; set; }
        public string email { get; set; }
        public string street { get; set; }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>()
            {
                new User() {
                          imageUrl = "https://randomuser.me/api/portraits/women/65.jpg",
                          fullname=  "mrs sofie rasmussen",
                          rating="4.5",
                          email= "sofie.rasmussen@example.com",
                          street= "8865 kaj munks vej"
                        },
                new User() {
                        imageUrl= "https://randomuser.me/api/portraits/men/49.jpg",
                        fullname= "mr lee austin",
                         rating="4.6",
                         email= "lee.austin@example.com",
                          street= "1582 hillcrest rd",
                }

            };
            return users;
        }
       
    }
}
