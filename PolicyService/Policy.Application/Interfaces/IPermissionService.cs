using Policy.Application.DTOs;
using Policy.Data.Entities;

namespace Policy.Application.Interfaces
{
    public interface IPermissionService
    {
        void Update(PermissionDTO permission);
        PermissionDTO Select(string code);
    }
}
