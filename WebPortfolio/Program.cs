using MailKit;
using WebPortfolio.Services.EmailService;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IEmailService,EmailService>();
builder.Services.AddControllersWithViews();
var app = builder.Build();

/* TODO 
 *     EmailService resume: 2-Step Verification 
 *     FarmEcommerce Slider + Links
 *     VirtuBooks (Preliminary) Slider + Links
 *     Dastru Project: ReadMe
 *     
 */
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
