using JadoTravel.Features.Mediator.Commands.TestimonialCommands;
using JadoTravel.Features.Mediator.Queries.TestimonialQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.Controllers
{
    public class AdminTestimonialController : Controller
    {
        private readonly IMediator _mediator;

        public AdminTestimonialController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetTestimonialQuery());
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            await _mediator.Send(new RemoveTestimonialCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateTestimonial(int id)
        {
            var value = await _mediator.Send(new GetTestimonialByIdQuery(id));

            var testimonial = new UpdateTestimonialCommand
            {
                TestimonialId = value.TestimonialId,
                City = value.City,
                Description = value.Description,
                NameSurname = value.NameSurname,
                ImageUrl = value.ImageUrl
            };
            return View(testimonial);
        }

        [HttpPost]
		public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }



	}
}
