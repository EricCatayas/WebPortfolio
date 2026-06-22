namespace WebPortfolio.Models
{
    public class WorkExperience
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Type { get; set; }
        public Company Company { get; set; }
        public string Link { get; set; }
        public string ImageUrl { get; set; }
        public List<string> Contributions { get; set; }
        public List<string> Technologies { get; set; }
    }
}
