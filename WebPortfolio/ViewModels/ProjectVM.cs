using WebPortfolio.Models;

namespace WebPortfolio.ViewModels
{
    public class ProjectVM : Project
    {
        public ProjectVM(Project project, string style)
        {
            Id = project.Id;
            Title = project.Title;
            Description = project.Description;
            Link = project.Link;
            GithubLink = project.GithubLink;
            ImageUrl = project.ImageUrl;
            ThumbnailUrl = project.ThumbnailUrl;
            Style = style;
        }
        public string Style { get; set; }
    }
}
