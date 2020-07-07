using AutoMapper;
using Policy.Application.DTOs;
using Policy.Application.Interfaces;
using Policy.Data.Entities;
using Policy.Infrastructure.CustomException;
using Policy.Infrastructure.Exception;
using Policy.Infrastructure.Interfaces;
using System;
using System.Linq;

namespace Policy.Application.Implementations
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<Student, string> _studenRepo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StudentService(IRepository<Student, string> studentRepo, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _studenRepo = studentRepo;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Delete(string id)
        {

            throw new NotImplementedException();
        }

        public void Insert(Student student)
        {
            student.Id = Guid.NewGuid().ToString();
            student.CreatedDate = DateTime.Now;
            _studenRepo.Add(student);
            _unitOfWork.SaveChanges();
        }

        public StudentDTO Select(string code)
        {
            Student student = _studenRepo.FindAll(x => x.Code == code).FirstOrDefault();
            if (student == null) throw new UserException(ErrorStatusReturn.ADDRESS_DETAIL_NOT_FOUND);
            StudentDTO resultStudent = _mapper.Map<StudentDTO>(student);
            return resultStudent;
        }
    }
}
