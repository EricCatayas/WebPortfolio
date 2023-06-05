using MailKit;
using WebPortfolio.Services.EmailService;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IEmailService,EmailService>();
builder.Services.AddControllersWithViews();
var app = builder.Build();

/* TODO  Horraay! 90% Complete!
 *     So.. tell me more about your projects? Back-end Tools section
 *     Personal Picture for About section
 *     Ericjay trans -> Logo
 *     Portfolio.pdf
 *     Contacts Management Finish Product Picture + Stocks Demo
 *     Tropical Campgrounds picture as well
 */
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
