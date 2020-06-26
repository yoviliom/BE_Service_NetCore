using AutoMapper;
using Policy.Application.DTOs;
using Policy.Application.Interfaces;
using Policy.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Policy.Application.Implementations
{
    public class ProfileService : IProfileService
    {
        private readonly IRepository<Profile, long> _profileRepo;
        private readonly IUnitOfWork _unitOfWork;

        public ProfileService(IRepository<Profile, long> profileRepo, IUnitOfWork unitOfWork)
        {
            _profileRepo = profileRepo;
            _unitOfWork = unitOfWork;
        }


    }
}
