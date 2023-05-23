using Microsoft.EntityFrameworkCore;

namespace TestWebAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Address { get; set; }
        public string Contact { get; set; }
        public string Country { get; set; } 


    }
}
