using Microsoft.AspNetCore.Identity;

namespace WeBBERBER.Models
{
    public class UserDetails : IdentityUser
    {
        public string UserAd { get; set; }
        public string UserSoyad { get; set; }
    }
}
    

