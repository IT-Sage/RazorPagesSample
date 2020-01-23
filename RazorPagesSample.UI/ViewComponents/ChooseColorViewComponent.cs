using Microsoft.AspNetCore.Mvc;
using RazorPagesSample.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesSample.UI.ViewComponents
{
    [BindProperties]
    public class ChooseColorViewComponent : ViewComponent
    {
        public Color SelectedColor { get; set; }
        public List<Color> Colors { get; set; }
        public ChooseColorViewComponent()
        {
            Colors = new List<Color>();
            foreach (var item in Enum.GetValues(typeof(Color)))
            {
                Colors.Add((Color)item);
            }
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {            
            return View(this);
        }
    }
}
