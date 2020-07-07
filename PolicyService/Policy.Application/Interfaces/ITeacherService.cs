using Policy.Application.DTOs;
using Policy.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Policy.Application.Interfaces
{
    public interface ITeacherService
    {
        void Insert(Teacher teacher);
        TeacherDTO Select(string code);
        void Delete(string id);
    }
}
