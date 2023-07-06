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
        public IActionResult GetCoure(string id)
        {
            Course course = courses.Find(el => el.Id == id);

            return Ok(course);
        }

        [HttpPost]
        [Route("")]
        public IActionResult CreateCoures(CreateCourseDto data)
        {
            Console.WriteLine(data);

            Course course = new Course{
                Id = Guid.NewGuid().ToString(),
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                CategoryId = data.CategoryId,
            };
            courses.Add(course);

            return Ok(course);
        }
    }
};
