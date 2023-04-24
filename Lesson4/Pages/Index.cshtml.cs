using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Net.WebRequestMethods;

namespace Lesson4.Pages
{
    public class IndexModel : PageModel
    {
        public const string IMG = "https://media.licdn.com/dms/image/C4D03AQHCQcyzZ4fx2w/profile-displayphoto-shrink_800_800/0/1572446924667?e=2147483647&v=beta&t=lrnXobLdbrih7sSYFWz_g0428hdlONlwT9wKJG11D3k";

        public void OnGet()
        {

        }
    }
}