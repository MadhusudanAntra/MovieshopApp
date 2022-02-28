using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class CastService : ICastService
    {
        private readonly ICastRepository _castService;

        public CastService(ICastRepository castService)
        {
            _castService = castService;
        }
        public CastResponseModel GetAllCast(int id)
        {

            var castDeatil =  _castService.GetById(id);

            var castModels = new CastResponseModel
            {
                Id = castDeatil.Id,
                Name = castDeatil.Name,
                Gender = castDeatil.Gender,
               
                ProfilePath = castDeatil.ProfilePath
            };

            
            return castModels;
        }
    }
}
