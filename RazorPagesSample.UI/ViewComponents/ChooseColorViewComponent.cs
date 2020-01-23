using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public List<SelectListItem> Items { get; set; }
        public Color SelectedColor { get; set; }

        public ChooseColorViewComponent()
        {
            Items = new List<SelectListItem>();
            foreach (var item in Enum.GetValues(typeof(Color)))
            {
                Items.Add(
                    new SelectListItem(item.ToString(),item.ToString()));
            }
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            TempData["superklic"] = Items[2].Value;//.FirstOrDefault(item => item.Selected == true);
            return View(this);
        }        
    }
}
