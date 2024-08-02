using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.ViewComponents.Default
{
    public class _DefaultDestinationComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
