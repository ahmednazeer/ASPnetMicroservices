using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discount.API.Entities;

namespace Discount.API.Repositories
{
    public interface IDiscountRepository
    {
        Task<Coupon> GetDiscount(string productName);
        Task<bool> CreateDiscount(Coupon discountCoupon);
        Task<bool> UpdateDiscount(Coupon discountCoupon);
        Task<bool> DeleteDiscount(string productName);
    }
}
