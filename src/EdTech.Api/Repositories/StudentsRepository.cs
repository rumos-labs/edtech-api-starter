using EdTech.Api.Models;

namespace EdTech.Api.Repositories;

public class StudentsRepository : IRepository<Student>
{
    private readonly EdTechDbContext context;

    public StudentsRepository(EdTechDbContext context)
    {
        this.context = context;
    }

    public Student Add(Student entity)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public Student? Get(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public IEnumerable<Student> GetAll()
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public void Update(Student entity)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }
}
