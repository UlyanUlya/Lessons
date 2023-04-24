using Lesson4.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson4.Pages.Hobbies
{
    public class HobbyDetailsModel : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public int Id { get; set; }
        public Hobby Hobby { get; set; }
        public async Task OnGetAsync() => Hobby = new Hobby()
        {
            HobbyId = 1,
            Name = "Painting",
            Description = "I Paint from the very begining of my life",
            //Image = "C:\Users\Uliana.Hordiienko\source\repos\C#\Internal\Part2\Lessons\Lesson4\Pages\Images\017.jpg",
            Url = "https://www.instagram.com/ulyan_ulya/"
        };
    }
}
