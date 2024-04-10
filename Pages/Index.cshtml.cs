using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mycoreproject.Pages
{
    public class IndexModel : PageModel
    {
        public required List<DefaultData> DataSource { get; set; }
        public void OnGet()
        {
            DataSource = GetDefaultData();
        }

        public List<DefaultData> GetDefaultData()
        {
            List<DefaultData> DefaultData =
            [
                new() {
                    Id = 1,
                    Subject = "Environment Day",
                    StartTime = new DateTime(2024, 4, 2, 9, 0, 0),
                    EndTime = new DateTime(2024, 4, 2, 14, 0, 0),
                    PrimaryColor = "#1aaa55",
                    SecondaryColor = "#47bb76",
                    ImageName = "environment-day",
                    Url = "https://ej2.syncfusion.com/aspnetcore/css/schedule/images/environment-day.svg",
                    Description = "A day that creates awareness to promote the healthy planet and reduce the air pollution crisis on nature earth."
                },
                new() {
                    Id = 2,
                    Subject = "Health Day",
                    StartTime = new DateTime(2024, 4, 3, 9, 0, 0),
                    EndTime = new DateTime(2024, 4, 3, 14, 0, 0),
                    PrimaryColor = "#357cd2",
                    SecondaryColor = "#5d96db",
                    ImageName = "health-day",
                    Url = "https://ej2.syncfusion.com/aspnetcore/css/schedule/images/health-day.svg",
                    Description = "A day that raises awareness on different health issues. It marks the anniversary of the foundation of WHO."
                },
                new() {
                    Id = 3,
                    Subject = "Cancer Day",
                    StartTime = new DateTime(2024, 4, 4, 9, 0, 0),
                    EndTime = new DateTime(2024, 4, 4, 14, 0, 0),
                    PrimaryColor = "#7fa900",
                    SecondaryColor = "#a4c932",
                    ImageName = "cancer-day",
                    Url = "https://ej2.syncfusion.com/aspnetcore/css/schedule/images/cancer-day.svg",
                    Description = "A day that raises awareness on cancer and its preventive measures. Early detection saves life."
                }
            ];
            return DefaultData;
        }

        public class DefaultData
        {
            public int Id { get; set; }
            public string Subject { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public string Description { get; set; }
            public string ImageName { get; set; }
            public string Url { get; set; }

            public string PrimaryColor { get; set; }
            public string SecondaryColor { get; set;}
        }
    }
}
