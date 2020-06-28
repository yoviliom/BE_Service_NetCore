using Policy.Application.DTOs;
using Policy.Application.Interfaces;
using Policy.Data.Entities;
using Policy.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Policy.Application.Implementations
{
    public class ProvinceService: IProvinceService
    {
        private readonly IRepository<Province, string> _provinceRepo;
        private readonly IUnitOfWork _unitOfWork;

        public ProvinceService(IRepository<Province, string> provinceRepo, IUnitOfWork unitOfWork)
        {
            _provinceRepo = provinceRepo;
            _unitOfWork = unitOfWork;
        }

        public void Insert(Province province)
        {
            province.Id = Guid.NewGuid().ToString();
            province.CreatedDate = DateTime.Now;
            _provinceRepo.Add(province);
            _unitOfWork.SaveChanges();
        }
    }
}
