using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.ViewComponents.UILayout
{
    public class _UILayoutNavbarComponent : ViewComponent
    {
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
