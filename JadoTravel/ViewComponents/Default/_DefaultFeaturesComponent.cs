using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.ViewComponents.Default
{
    public class _DefaultFeaturesComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
