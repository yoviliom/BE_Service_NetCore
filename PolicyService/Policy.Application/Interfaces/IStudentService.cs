using Policy.Application.DTOs;
using Policy.Data.Entities;

namespace Policy.Application.Interfaces
{
    public interface IStudentService
    {
        void Insert(Student student);
        StudentDTO Select(string code);
        void Delete(string id);
    }
}
