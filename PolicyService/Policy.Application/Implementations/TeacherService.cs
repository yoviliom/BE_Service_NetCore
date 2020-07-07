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
    public class TeacherService : ITeacherService
    {

        private readonly IRepository<Teacher, string> _teacherRepo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TeacherService(IRepository<Teacher, string> teacherRepo, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _teacherRepo = teacherRepo;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public void Delete(string code)
        {
            Teacher teacher = _teacherRepo.FindAll(x => x.Code == code).FirstOrDefault();
            if (teacher == null) throw new UserException(ErrorStatusReturn.NOT_FOUND);
            _teacherRepo.Remove(teacher);
            _unitOfWork.SaveChanges();
        }

        public void Insert(Teacher teacher)
        {
            teacher.Id = Guid.NewGuid().ToString();
            teacher.CreatedDate = DateTime.Now;
            _teacherRepo.Add(teacher);
            _unitOfWork.SaveChanges();
        }

        public TeacherDTO Select(string code)
        {
            Teacher teacher = _teacherRepo.FindAll(x => x.Code == code).FirstOrDefault();
            if (teacher == null) throw new UserException(ErrorStatusReturn.NOT_FOUND);
            TeacherDTO resultTeacher = _mapper.Map<TeacherDTO>(teacher);
            return resultTeacher;
        }
    }
}
