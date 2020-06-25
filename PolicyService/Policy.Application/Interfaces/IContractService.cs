using Policy.Application.DTOs;
using Policy.Infrastructure.Pagination;

namespace Policy.Application.Interfaces
{
    public interface IContractService
    {
        PagedResult<ContractDTO> SearchAndPagging(int province, int page, int pageSize);

        void Insert(ContractDTO contract);

        void Update(ContractDTO contract);

        void Delete(ContractDTO contract);
    }
}