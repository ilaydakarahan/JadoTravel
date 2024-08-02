using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.ViewComponents.UILayout
{
    public class _UILayoutHeadComponent : ViewComponent
    {
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();
		}
	}
}
