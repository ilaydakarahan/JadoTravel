using JadoTravel.DataAccess.Abstract;
using JadoTravel.DataAccess.Context;
using JadoTravel.DataAccess.Repositories;
using JadoTravel.Features.CQRS.Handlers.DestinationHandlers;
using JadoTravel.Features.CQRS.Handlers.FeatureHandlers;
using JadoTravel.Features.CQRS.Handlers.StepHandlers;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<JadooContext>();

builder.Services.AddScoped<GetDestinationQueryHandler>();
builder.Services.AddScoped<GetDestinationByIdQueryHandler>();
builder.Services.AddScoped<CreateDestinationCommandHandler>();
builder.Services.AddScoped<RemoveDestinationCommandHandler>();
builder.Services.AddScoped<UpdateDestinationCommandHandler>();

builder.Services.AddScoped<GetFeatureQueryHandler>();
builder.Services.AddScoped<GetFeatureByIdQueryHandler>();
builder.Services.AddScoped<UpdateFeatureCommandHandler>();


builder.Services.AddScoped<GetStepQueryHandler>();
builder.Services.AddScoped<GetStepByIdQueryHandler>();
builder.Services.AddScoped<CreateStepCommandHandler>();
builder.Services.AddScoped<RemoveStepCommandHandler>();
builder.Services.AddScoped<UpdateStepCommandHandler>();

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
});

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));


builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
