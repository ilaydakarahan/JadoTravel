using JadoTravel.Features.Mediator.Commands.CompanyCommands;
using JadoTravel.Features.Mediator.Queries.CompanyQueries;
using JadoTravel.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.Controllers
{
	public class AdminCompanyController : Controller
	{
		private readonly IMediator _mediator;

		public AdminCompanyController(IMediator mediator)
		{
			_mediator = mediator;
		}

		public async Task<IActionResult> Index()
		{
			var values = await _mediator.Send(new GetCompanyQuery());
			return View(values);
		}
		//[HttpPost]
		//public async Task<IActionResult> Index(CompanyImageViewModel model)
		//{
		//	var extension = Path.GetExtension(model.ImageFile.FileName);
		//	var imageName =Guid.NewGuid() + extension;
		//	var saveLocation = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", imageName); 
		//	var stream = new FileStream(saveLocation, FileMode.Create);
		//	model.ImageFile.CopyTo(stream);
		//	return "/images/" + imageName;

		//}

		[HttpGet]
		public IActionResult CreateCompany()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateCompany(CreateCompanyCommand command)
		{
			await _mediator.Send(command);
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> DeleteCompany(int id)
		{
			await _mediator.Send(new RemoveCompanyCommand(id));
			return RedirectToAction("Index");

		}
	}
}
