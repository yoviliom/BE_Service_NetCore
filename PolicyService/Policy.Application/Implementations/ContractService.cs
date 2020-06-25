using AutoMapper;
using AutoMapper.QueryableExtensions;
using Policy.Application.DTOs;
using Policy.Application.Interfaces;
using Policy.Data.Entities;
using Policy.Infrastructure.Interfaces;
using Policy.Infrastructure.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Policy.Application.Implementations
{
    public class ContractService: IContractService
    {
        private readonly IRepository<Contract, long> _contractRepo;
        private readonly IUnitOfWork _unitOfWork;

        public ContractService(IRepository<Contract, long> contractRepo, IUnitOfWork unitOfWork)
        {
            _contractRepo = contractRepo;
            _unitOfWork = unitOfWork;
        }

        public PagedResult<ContractDTO> SearchAndPagging(int province, int page, int pageSize)
        {
            var query = _contractRepo.FindAll();

            int totalRow = query.Count();

            query = query.OrderByDescending(x => x.Status).
                ThenBy(x => x.CreatedDate).Skip((page - 1) * pageSize).Take(pageSize);

            var pagingData = query.ProjectTo<ContractDTO>().ToList();

            return new PagedResult<ContractDTO>()
            {
                Results = pagingData,
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };
        }

        public void Insert(ContractDTO contract)
        {
            Contract contactInsert = Mapper.Map<Contract>(contract);

            _contractRepo.Add(contactInsert);

            _unitOfWork.SaveChanges();
        }
        public void Update(ContractDTO contract)
        {

        }
        public void Delete(ContractDTO contract)
        {

        }
    }
}
