using System;
using System.Collections.Generic;
using System.Text;

namespace Policy.Application.DTOs
{
    public class PermissionDTO
    {
        public string Code { get; set; }
        public int UserType { get; set; }
        public bool SystemManager { get; set; }
        public bool StudentManager { get; set; }
        public bool TeacherManager { get; set; }
        public bool ScorceManager { get; set; }
        public bool ClassManager { get; set; }
        public bool ConductManager { get; set; }
    }
}
