using WebPortfolio.Models;

namespace WebPortfolio.Data
{
    public static class WorkExperienceData
    {
        public static readonly List<WorkExperience> Experiences = new List<WorkExperience>
        {                        
            new WorkExperience
            {
                Id = "efficientrix-intern",
                Title = "Quality Assurance Intern (250 hrs.)",
                Date = "January 2025 - June 2025",
                Company = new Company
                {
                    Name = "Efficientrix IT Solutions",
                    Location = "Tipolo, Mandaue City, Cebu",
                    Link = "https://efficientrix.com/"
                },
                Type = "Onsite",
                ImageUrl = "~/images/work/efficientrix-certificate.png",
                Description = "As part of our curriculum, I took a Quality Assurance internship at Efficientrix IT Solutions. During this time, we worked on a beauty contest voting application. I gained experience in testing, identifying, and reporting bugs in a team environment.",
                Contributions = new List<string>
                {
                    "Conducted manual testing of web applications to identify and report bugs",
                    "Collaborated with a team of developers to test features for a beauty contest voting system"
                },
                Technologies = new List<string>
                {
                    "ClickUp",
                    "Laravel"
                }
            },

            new WorkExperience
            {
                Id = "mdv-developer",
                Title = "Part-time Full Stack Developer",
                Date = "September 2024 - June 2025",
                Company = new Company
                {
                    Name = "My Dream Visa LLC",
                    Location = "Tampa, Florida, USA",
                    Link = "https://mydreamvisa.com/",
                },
                Type = "Remote",
                ImageUrl = "~/images/work/mdv-landing.png",
                Description = "Following the completion of my internship, I was offered a part-time position as a Junior Full Stack Developer at My Dream Visa. In this role, I contributed to the development of new USCIS immigration services, including the Parent Green Card application, Form I-751, and Form I-129F.",
                Contributions = new List<string>
                {
                    "Refined UI inconsistencies between USCIS, Form I-751, and Form I-129F immigration services using Vue.Js components",
                    "Implemented route-based access control and locking logic to prevent unauthorized page access and improve application security",
                    "Added a caching system to the eligibility quiz page to retain user data after registration",
                    "Developed a paywall system to restrict premium application features based on user subscription",
                    "Implemented 503 service unavailable handling logic for server maintenance and updates",
                },
                Technologies = new List<string>
                {
                    "Vue.js",
                    "Express.js",
                    "Node.js",
                    "MySQL",
                    "Quasar",
                    "HTML",
                    "CSS",
                    "JavaScript",
                    "TypeScript"
                }
            },

            new WorkExperience
            {
                Id = "mdv-intern",
                Title = "Full Stack Development Intern (500 hrs.)",
                Date = "June 2024 - October 2024",
                Company = new Company
                {
                    Name = "My Dream Visa LLC",
                    Location = "Tampa, Florida, USA",
                    Link = "https://mydreamvisa.com/",
                },
                Type = "Remote",
                ImageUrl = "~/images/work/mdv-certificate.jpg",
                Description = "In the summer of 2024, I volunteered as a Full Stack Development Intern to enhance my skills and gain hands-on experience. During the internship, we developed an application designed to streamline the USCIS marriage-based green card application process.",
                Contributions = new List<string>
                {
                    "Integrate a live chat and customer support interface using Tawk.to to improve communication between users and support staff",
                    "Implemented dynamic form fields with auto-fill functionality to simplify complex application workflows",
                    "Developed and validated input formatting for phone numbers, currency, SSNs, and A-numbers",
                    "Refactored frontend code to improve readability and code maintainability"
                },
                Technologies = new List<string>
                {
                    "Vue.js",
                    "Express.js",
                    "Node.js",
                    "MySQL",
                    "HTML",
                    "CSS",
                    "JavaScript",
                    "TypeScript"
                }
            },
        };
    }
}
