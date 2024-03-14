using EdTech.Api.Models;

namespace EdTech.Api.Repositories;

public class CoursesRepository : IRepository<Course>
{
    private readonly EdTechDbContext context;

    public CoursesRepository(EdTechDbContext context)
    {
        this.context = context;
    }

    public Course Add(Course entity)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public Course? Get(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public IEnumerable<Course> GetAll()
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public void Update(Course entity)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }
}
