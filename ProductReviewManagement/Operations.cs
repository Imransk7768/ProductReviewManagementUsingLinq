using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Operations
    {
        public void GetTopThreeRecords(List<ProductReview> list)
        {
            var result = list.OrderByDescending(x => x.Rating).Take(3).ToList();
            Display(result);
        }
        public void Display(List<ProductReview> list)
        {
            foreach (var product in list)
            {
                Console.WriteLine("PRODUCTID : " + product.ProductId + ", USERID : " + product.UserId + ", RATING : " + product.Rating +
                    ", REVIEW : " + product.Review + ", STATUS : " + product.IsLike);
            }
        }

    }
}
