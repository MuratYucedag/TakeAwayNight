using Dapper;
using TakeAwayNight.Discount.Context;
using TakeAwayNight.Discount.Dtos;

namespace TakeAwayNight.Discount.Services
{
	public class DiscountCouponService : IDiscountCouponService
	{
		private readonly DapperContext _context;
		public DiscountCouponService(DapperContext context)
		{
			_context = context;
		}
		public async Task CreateDiscountCouponAsync(CreateDiscountCouponDto createDiscountCouponDto)
		{
			string query = "insert into DiscountCoupons (Rate,Code,IsActive) values (@rate,@code,@isActive)";
			var parameters = new DynamicParameters();
			parameters.Add("@rate", createDiscountCouponDto.Rate);
			parameters.Add("@code", createDiscountCouponDto.Code);
			parameters.Add("@isActive", createDiscountCouponDto.IsActive);
			var connection = _context.CreateConnection();
			await connection.ExecuteAsync(query, parameters);
		}
		public async Task DeleteDiscountCouponAsync(int id)
		{
			string query = "Delete From DiscountCoupons Where DiscountCouponId=@discountCouponId";
			var parameters = new DynamicParameters();
			parameters.Add("@discountCouponId", id);
			var connection = _context.CreateConnection();
			await connection.ExecuteAsync(query, parameters);
		}
		public async Task<GetByIdDiscountCouponDto> GetByIdDiscountCouponAsync(int id)
		{
			string query = "Select * From DiscountCoupons Where DiscountCouponId=@discountCouponId";
			var parameters = new DynamicParameters();
			parameters.Add("@discountCouponId", id);
			var connection = _context.CreateConnection();
			var values = await connection.QueryFirstOrDefaultAsync<GetByIdDiscountCouponDto>(query);
			return values;
		}
		public async Task<List<ResultDiscountCouponDto>> GetResultDiscountCouponAsync()
		{
			string query = "Select * From DiscountCoupons";
			var connection = _context.CreateConnection();
			var values = await connection.QueryAsync<ResultDiscountCouponDto>(query);
			return values.ToList();
		}
		public async Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateDiscountCouponDto)
		{
			string query = "Update DiscountCoupons Set Code=@code,Rate=@rate,IsActive=@isActive where DiscountCouponId=@discountCouponId";
			var parameters = new DynamicParameters();
			parameters.Add("@code", updateDiscountCouponDto.Code);
			parameters.Add("@rate", updateDiscountCouponDto.Rate);
			parameters.Add("@isActive", updateDiscountCouponDto.IsActive);
			parameters.Add("@discountCouponId", updateDiscountCouponDto.DiscountCouponId);
			var connection = _context.CreateConnection();
			await connection.ExecuteAsync(query, parameters);
		}
	}
}
