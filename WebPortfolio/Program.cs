using MailKit;
using WebPortfolio.Services.EmailService;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IEmailService,EmailService>();
builder.Services.AddControllersWithViews();
var app = builder.Build();

/* TODO 
 *     [ ] Get Written Approval from MDV
 *     [ ] Update Landing Page
 *     [ ] Add Job/Work History Section
 *         [ ] Add Read More button
 *         [ ] Upload MDV Images
 *         [ ] Navbar add link to Job/Work/Experience
 *     [ ] Upload Resume 2025
 *     [ ] Mobile Phone Responsiveness: Enlarge text, center content, remove white space
 *     
 */
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
