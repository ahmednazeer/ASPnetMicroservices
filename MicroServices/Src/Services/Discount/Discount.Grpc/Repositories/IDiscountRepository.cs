using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discount.Grpc.Entities;

namespace Discount.Grpc.Repositories
{
    public interface IDiscountRepository
    {
        Task<Coupon> GetDiscount(string productName);
        Task<bool> CreateDiscount(Coupon discountCoupon);
        Task<bool> UpdateDiscount(Coupon discountCoupon);
        Task<bool> DeleteDiscount(string productName);
    }
}
