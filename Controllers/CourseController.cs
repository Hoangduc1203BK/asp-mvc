using System.Net;
using Microsoft.AspNetCore.Mvc;
using mvc_project.Model;
using mvc_project.Model.dto;
namespace mvc_project.Controllers
{
    [ApiController]
    [Route("/course")]
    public class CourseController : Controller
    {
        public CourseController() { }
        public static List<Course> courses = new List<Course>();

        [HttpGet]
        [Route("")]
        public  IActionResult ListCourse()
        {
            return Ok(courses);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetCoure(int id)
        {
            Course course = courses.Find(el => el.Id == id);

            return Ok(course);
        }

        [HttpPost]
        [Route("")]
        public IActionResult CreateCoures(CreateCoureDto data)
        {
            Console.WriteLine(data);

            Course course = new Course{
                Id = int.Parse(Guid.NewGuid().ToString()),
                Name = "abc",
                Description = "def",
                Price = 10,
                CategoryId = 1,
            };
            courses.Add(course);

            return Ok(course);
        }
    }
};
