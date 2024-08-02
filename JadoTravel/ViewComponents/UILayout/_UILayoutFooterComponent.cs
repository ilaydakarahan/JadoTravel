using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.ViewComponents.UILayout
{
    public class _UILayoutFooterComponent : ViewComponent
    {
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();
		}
	}
}
