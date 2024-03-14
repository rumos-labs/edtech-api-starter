using EdTech.Api.Models;

using Microsoft.AspNetCore.Mvc;

namespace EdTech.Api.Controllers;

[ApiController]
[Route("api/v1/students")]
public class StudentsController : ControllerBase
{
    // TODO: Inject the repositories
    public StudentsController()
    {
    }

    [HttpGet]
    public ActionResult<IEnumerable<Student>> Get()
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public ActionResult<Student> Get(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpPost]
    public ActionResult<Student> Post(Student student)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    public ActionResult<Student> Put(int id, Student student)
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
}
