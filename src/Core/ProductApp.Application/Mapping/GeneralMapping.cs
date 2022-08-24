using AutoMapper;
using ProductApp.Application.Features.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<ProductApp.Entities.Product, Dto.ProductViewDto>().ReverseMap();
            CreateMap<ProductApp.Entities.Product, CreateProduct>().ReverseMap();
        }
    }
}
