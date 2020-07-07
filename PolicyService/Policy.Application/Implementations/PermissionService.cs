using AutoMapper;
using Policy.Application.DTOs;
using Policy.Application.Interfaces;
using Policy.Data.Entities;
using Policy.Infrastructure.CustomException;
using Policy.Infrastructure.Exception;
using Policy.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Policy.Application.Implementations
{
    public class PermissionService : IPermissionService
    {
        private readonly IRepository<Permission, string> _permissionRepo;
        private readonly IRepository<Teacher, string> _teacherRepo;
        private readonly IRepository<Student, string> _studentRepo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PermissionService(IRepository<Permission, string> permissionRepo, IRepository<Teacher, string> teacherRepo, IRepository<Student, string> studentRepo, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _permissionRepo = permissionRepo;
            _studentRepo = studentRepo;
            _teacherRepo = teacherRepo;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public PermissionDTO Select(string code)
        {
            Student student = _studentRepo.FindAll(x => x.Code == code).FirstOrDefault();
            Teacher teacher = _teacherRepo.FindAll(x => x.Code == code).FirstOrDefault();
            if (student == null || teacher == null) throw new UserException(ErrorStatusReturn.NOT_FOUND);

            Permission permission = _permissionRepo.FindAll(x => x.Code == student.Code).FirstOrDefault();
            if (permission == null)
            {
                permission = _permissionRepo.FindAll(x => x.Code == teacher.Code).FirstOrDefault();
            }
            if (permission == null) throw new UserException(ErrorStatusReturn.NOT_FOUND);
            PermissionDTO permissions = _mapper.Map<PermissionDTO>(permission);
            switch (permissions.UserType)
            {
                case 1: // System Admin
                    permissions.SystemManager = true;
                    permissions.TeacherManager = false;
                    permissions.StudentManager = false;
                    permissions.ScorceManager = false;
                    permissions.ClassManager = false;
                    permissions.ConductManager = false;
                    break;
                case 2: // Academic
                    permissions.SystemManager = false;
                    permissions.TeacherManager = true;
                    permissions.StudentManager = true;
                    permissions.ScorceManager = true;
                    permissions.ClassManager = true;
                    permissions.ConductManager = true;
                    break;
                case 3: // Teacher
                    permissions.SystemManager = false;
                    permissions.TeacherManager = true;
                    permissions.StudentManager = false;
                    permissions.ScorceManager = true;
                    permissions.ClassManager = false;
                    permissions.ConductManager = true;
                    break;
                case 4: // Teacher
                    permissions.SystemManager = false;
                    permissions.TeacherManager = false;
                    permissions.StudentManager = true;
                    permissions.ScorceManager = true;
                    permissions.ClassManager = false;
                    permissions.ConductManager = false;
                    break;
            }
            return permissions;
        }

        public void Update(PermissionDTO permission)
        {

        }
    }
}
