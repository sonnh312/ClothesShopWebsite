using ClothesShopWebsite.Data;
using Microsoft.AspNetCore.Mvc;

namespace ClothesShopWebsite.ViewComponent
{
	public class IntroduceNewProductViewComponent
	{
		private readonly Hshop2023Context db;

		public IntroduceNewProductViewComponent(Hshop2023Context context) => db = context;
		public IViewComponentResult Invoke()
		{
			var data = db.ChuDes.Select(topic => new {
				topic.MaCd,topic.TenCd 
			});
		}

	}
}
