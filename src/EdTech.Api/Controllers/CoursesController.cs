using EdTech.Api.Models;

using Microsoft.AspNetCore.Mvc;

namespace EdTech.Api.Controllers;

[ApiController]
[Route("api/v1/courses")]
public class CoursesController : ControllerBase
{
    // TODO: Inject the repositories
    public CoursesController()
    {
    }

    [HttpGet]
    public ActionResult<IEnumerable<Course>> Get()
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public ActionResult<Course> Get(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpPost]
    public ActionResult<Course> Post(Course course)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    public ActionResult<Course> Put(int id, Course course)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpPost("{id}/enroll/{studentId}")]
    public ActionResult<Course> Enroll(int id, int studentId, Enrollment enrollment)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }
}
