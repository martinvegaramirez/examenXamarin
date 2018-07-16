
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
        public string city { get; set; }
        public string state { get; set; }
        public string postalcode { get; set; }
        public string telephone { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public List<User> GetUsers()
        {
            List<User> users = new List<User>()
            {
                new User() {
                          imageUrl = "https://randomuser.me/api/portraits/women/65.jpg",
                          fullname=  "mrs sofie rasmussen",
                          rating="4.5",
                          email= "sofie.rasmussen@example.com",
                          street= "8865 kaj munks vej",
                           city= "Nicolas Romero",
                            state = "Estado de Mexico",
                            postalcode ="55880",
                            telephone = "55.5546.7899",
                            lat ="19.535333",
                            lon ="-99.193800"
                        },
                new User() {
                        imageUrl= "https://randomuser.me/api/portraits/men/49.jpg",
                        fullname= "mr lee austin",
                         rating="4.6",
                         email= "lee.austin@example.com",
                         street= "1582 hillcrest rd",
                           city= "Nicolas Romero",
                        state = "Estado de Mexico",
                        postalcode ="55880",
                        telephone = "55.5546.7899",
                        lat ="19.535333",
                        lon ="-99.193800"
                },
                new User() {
                        imageUrl= "https://randomuser.me/api/portraits/men/80.jpg",
                        fullname= "mr norival castro",
                         rating="4.6",
                         email= "norival.castro@example.com",
                         street= "4119 rua dezenove de outubro",
                           city= "Nicolas Romero",
                        state = "rio de janeiro",
                        postalcode ="86062",
                        telephone = "(93) 7572-91549",
                        lat ="-69.1984",
                        lon ="-170.0286"
                },

            };
            return users;
        }
       
    }
}
