using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.ViewComponents.Default
{
    public class _DefaultTestimonialComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
