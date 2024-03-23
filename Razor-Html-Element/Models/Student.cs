using Microsoft.AspNetCore.Mvc.Rendering;

namespace Razor_Html_Element.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public List<SelectListItem> Lessons { get; set; }

        public int SelectedId { get; set; }
    }
}
