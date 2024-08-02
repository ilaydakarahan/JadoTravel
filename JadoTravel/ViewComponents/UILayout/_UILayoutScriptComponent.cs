using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.ViewComponents.UILayout
{
    public class _UILayoutScriptComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
