using Policy.Application.Interfaces;
using Policy.Data.Entities;
using Policy.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Policy.Application.Implementations
{
    class StudentService : IStudentService
    {
        private readonly IRepository<Student, long> _studenRepo;
        private readonly IUnitOfWork _unitOfWork;
        public void Insert()
        {
           
        }
    }
}
