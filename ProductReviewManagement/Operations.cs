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
        public void GetTopRecordsByProductIdRating(List<ProductReview> list)
        {
            var result = list.Where(x => x.Rating > 3 && (x.ProductId == 1 || x.ProductId == 4 || x.ProductId == 9)).Take(3).ToList();
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
        public void GetRecordsCountByProductId(List<ProductReview> list)
        {
            var result = list.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });
            foreach (var product in result)
            {
                Console.WriteLine("PRODUCTID : " + product.ProductId + ", Count " + product.Count);
            }
            Console.WriteLine("Count : " + list.Count);
        }
        public void GetAllRecordsProductId(List<ProductReview> list)
        {
            var result = list.OrderBy(x => x.ProductId).Select(x => new { productId = x.ProductId, Review = x.Review });
            foreach (var product in result)
            {
                Console.WriteLine("PRODUCTID : " + product.productId + ", REVIEW : " + product.Review);
            }
        }
    }
}
