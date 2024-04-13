using MailKit;
using WebPortfolio.Services.EmailService;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IEmailService,EmailService>();
builder.Services.AddControllersWithViews();
var app = builder.Build();

/* TODO 
 *     
 *     We can Make bg more pinkish violet
 *     Design Wise: 
 *         Mobile Phone Responsiveness: Enlarge text, center content, remove white space
 *     Dastru Project: ReadMe
 *     
 */
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
