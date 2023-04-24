using Lesson4.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson4.Pages.Hobbies
{
    public class MyHobbiesModel : PageModel
    {
        public List<Hobby> MyHobbies { get; set; } = new List<Hobby>();

        public async Task OnGetAsync()
        {
            MyHobbies.Add(new Hobby()
            {
                HobbyId = 1,
                Name = "Painting",
                Description = "I Paint from the very begining of my life",
                Image = "https://lh3.googleusercontent.com/-w-4P_jJW42drygNHjgx2me5GbHQGpbAYbEWSfe94FeOb4PgLWBA18wdLimA3Gx0tMyBqTW4tn1KD2CrbhZkkPY40riF5tnIjz6NyTY",
                Url = "https://www.instagram.com/ulyan_ulya/"
            });
            MyHobbies.Add(new Hobby()
            {
                HobbyId = 2,
                Name = "Playing Drums",
                Description = "I sarted playing drums in the University. I played in 3 rock bands",
                Image = "https://lh3.googleusercontent.com/N8ETNEdz8V9befF4KK60FNownyd7OtdWciN09wpq6MKnwV1UXeNofTVcw_bmj45HreKN4GdiILVhkP9MOZxcAS34noSyMVJiYp8FZv4",
                Url = "https://www.instagram.com/ulyan_ulya/"
            });
            MyHobbies.Add(new Hobby()
            {
                HobbyId = 3,
                Name = "Playing Piano",
                Description = "I'd been learning playing piano for 7 years",
                Image = "https://lh3.googleusercontent.com/Bv4TG0LHTICEeTseJ3LAug8Ryc4C_nTqfpLjjt7lPi5RpW7y6J3EmZ4zqqIUGUIcG3POAhrKHwTh7vNekWrMrRCT5gQIKVs-CMA8WS1M4g",
                Url = "https://www.instagram.com/ulyan_ulya/"
            });
            MyHobbies.Add(new Hobby()
            {
                HobbyId = 4,
                Name = "Embroidering",
                Description = "My grandmother tought me how to do it",
                Image = "https://lh3.googleusercontent.com/A_8JQ-smO02Tu9SD0y2W7BF8reOrvCTHWK31lEylw9XaKDRGy1dht77l7I6wJ-MdzoY1GFCdJ9UcpVhNiGE8PgNL23bupQIvuwTzkZ8",
                Url = "https://www.instagram.com/ulyan_ulya/"
            });
            MyHobbies.Add(new Hobby()
            {
                HobbyId = 5,
                Name = "Sewing",
                Description = "I like to make something unusual for my closest",
                Image = "https://lh3.googleusercontent.com/qDuipf9IuqRxWEoYmrbjH8bJ_BVnA1CkFIn5i_8Z-Z5oJvrBQLvpdOLbVdXTKVWrSnhZoCh_l4MAcj9a-hNRwaQGwxkOx2E0-7zGoSWk",
                Url = "https://www.instagram.com/ulyan_ulya/"
            });
            MyHobbies.Add(new Hobby()
            {
                HobbyId = 6,
                Name = "Photographing",
                Description = "I like to froze different moments of my life",
                Image = "https://lh3.googleusercontent.com/9i3IT0Q9t-t0G8kD2REPOTqt9QgeHvmZghvwwC8Wjp4Fhq8OC_IO74FapZgX5wgJOl8h-H1bYygs-Dfhk4VGQxIorJ6bTTW3PvZJfGRU",
                Url = "https://www.instagram.com/ulyan_ulya/"
            });
            MyHobbies.Add(new Hobby()
            {
                HobbyId = 7,
                Name = "Travelling",
                Description = "I like to travel a lot",
                Image = "https://lh3.googleusercontent.com/Xi1MpQxtc5OycO7K-up-1UmSfH0xb8a3_lLbK3fzTS-fRPI3C2k7Qq7GoMWIQjYUwAE508f0OlzWZNjmHxiA4bxeAdwJ7xxOcN9WB4p-",
                Url = "https://www.instagram.com/ulyan_ulya/"
            });
            MyHobbies.Add(new Hobby()
            {
                HobbyId = 8,
                Name = "Snowboarding",
                Description = "I like it a lot",
                Image = "https://lh3.googleusercontent.com/Q3tcGAJMmVpsw5cHAHjeQqhcQTkPVS7NrY0pvTZL69IcGRfBxuwU2WXMa7ODLl2t_yUFnE0tUJWJmgg8X1ge4l0VAEnLHMdxpOp7PEdp",
                Url = "https://www.instagram.com/ulyan_ulya/"
            });
        }
    }
}
