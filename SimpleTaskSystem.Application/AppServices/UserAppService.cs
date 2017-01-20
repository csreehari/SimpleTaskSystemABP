using Abp.Application.Services;
using SimpleTaskSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTaskSystem.Dtos;
using AutoMapper;

namespace SimpleTaskSystem.AppServices
{
    public class UserAppService : ApplicationService, IUserAppService
    {
        private IUserRepository _userRepository { get; set; }

        public UserAppService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public GetHoldersOutput GetHolders()
        {
            var holders = _userRepository.GetAllHolders();
            return new GetHoldersOutput
            {
                Holders = Mapper.Map<List<HolderDto>>(holders)
            };
        }

        public GetSeekersOutput GetSeekers()
        {
            var seekers = _userRepository.GetAllSeekers();
            return new GetSeekersOutput
            {
                Seekers = Mapper.Map<List<SeekerDto>>(seekers)
            };
        }
    }
}
