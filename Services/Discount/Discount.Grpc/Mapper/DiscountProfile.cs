using AutoMapper;
using Discount.Grpc.Entities;
using Discount.Grpc.Protos;

namespace Discount.Grpc.Mapper
{
    public class DiscountProfile : Profile
    {
        DiscountProfile() 
        {
            CreateMap<Coupon, CouponModel>().ReverseMap();
        }
    }
}
