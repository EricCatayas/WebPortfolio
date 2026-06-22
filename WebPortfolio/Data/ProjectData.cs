using WebPortfolio.Models;

namespace WebPortfolio.Data
{
    public static class ProjectData
    {
        public static List<Project> Projects = new()
    {
        new Project
        {
            Id = "up-cebu-exchange",
            Title = "UP Cebu Exchange",
            Description = "UP Cebu Exchange is a platform that provides rental services for artworks crafted by student Filipino artists from the University of the Philippines Cebu. The project was developed using Next.js and served as our capstone project during our final year in college.",
            Link = "https://up-cebu-exchange.vercel.app/",
            GithubLink = null,
            ImageUrl = "~/images/projects/up-cebu-exchange.png",
            ThumbnailUrl = "~/images/projects/up-cebu-exchange-thumbnail.jpeg"
        },

        new Project
        {
            Id = "tropical-campgrounds",
            Title = "Tropical Campgrounds",
            Description = "A site for users to share reviews and their experiences on camping sites throughout the Philippines. This app is inspired from Colt Steele's Yelp Camp app from his 60 hr. Udemy course: The Complete Web Development Bootcamp 2023.",
            Link = "https://tropicalcampground.azurewebsites.net",
            GithubLink = "https://github.com/EricCatayas/TropicalCampgrounds",
            ImageUrl = "~/images/projects/tropical-campgrounds.jpg",
            ThumbnailUrl = "~/images/projects/tropical-campgrounds-thumbnail.png"
        },

        new Project
        {
            Id = "agristore",
            Title = "AgriStore",
            Description = "This app is an online marketplace that facilitates exchange of agricultural products in the Philippines. It is inspired from Agro-Market24, an international agricultural exchange platform based in Europe.",
            Link = "https://agristore-online.netlify.app",
            GithubLink = "https://github.com/EricCatayas/Farm-Ecommerce-React",
            ImageUrl = "~/images/projects/agristore.jpg",
            ThumbnailUrl = "~/images/projects/agristore-thumbnail.jpeg"
        },

        new Project
        {
            Id = "farm-ecommerce-api",
            Title = "Farm Ecommerce API",
            Description = "This is a web API that serves as the backend for the AgriStore online marketplace. It is built using ASP.NET Core 7 and follows Clean Architecture principles for maintainability and scalability.",
            Link = "https://farmecommerce.azurewebsites.net/swagger/index.html",
            GithubLink = "https://github.com/EricCatayas/FarmEcommerce-WebAPI",
            ImageUrl = "~/images/projects/farm-ecommerce-api.png",
            ThumbnailUrl = "~/images/projects/farm-ecommerce-api.png"
        },

        new Project
        {
            Id = "virtubooks",
            Title = "Virtubooks",
            Description = "Virtubooks provides a virtual notebook experience to make digital note-taking and writing more engaging and interactive. A small personal project that I developed to practice my skills in WordPress.",
            Link = null, // "https://virtubooks.online"
            GithubLink = "https://github.com/EricCatayas/VirtubooksWP",
            ImageUrl = "~/images/projects/virtubooks.png",
            ThumbnailUrl = "~/images/projects/virtubooks.png"
        },

        new Project
        {
            Id = "contacts-management",
            Title = "Contacts Management",
            Description = "Contacts Management is a web app for organizing personal contacts, tracking logs, and managing important events or to-do lists. Developed using ASP.NET Core 7, this application embodies the principles of Clean Architecture, MVC, and Repository design pattern for scalability and modularity.",
            Link = "https://aspcontactsmanagement.azurewebsites.net",
            GithubLink = "https://github.com/EricCatayas/ContactsManagement",
            ImageUrl = "~/images/projects/contacts-management.png",
            ThumbnailUrl = "~/images/projects/contacts-management-thumbnail.png"
        },

        new Project
        {
            Id = "web-portfolio-v1",
            Title = "Old Web Portfolio",
            Description = "This is my old web portfolio built using ASP.NET Core 7 and Bootstrap -- same as this portfolio you're looking at! It landed me my first job as a web developer :D",
            Link = "https://ericcatayas.azurewebsites.net/v1",
            GithubLink = "https://github.com/EricCatayas/WebPortfolio",
            ImageUrl = "~/images/projects/web-portfolio-v1.png",
            ThumbnailUrl = "~/images/projects/web-portfolio-v1.png"
        },

        new Project
        {
            Id = "travel-records-app",
            Title = "Travel Records App (Xamarin Forms Project)",
            Description = "This project was inspired from Eduardo Rosas' cross platform IOS and Android application using Xamarin Forms, a 27.5 hr. course in Udemy.",
            Link = null,
            GithubLink = "https://github.com/EricCatayas/TravelRecordApp",
            ImageUrl = "~/images/projects/travel-records-app.png",
            ThumbnailUrl = "~/images/projects/travel-records-app.png"
        }
    };
    }
}
