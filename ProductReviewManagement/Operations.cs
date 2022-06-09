using System;
using System.Collections.Generic;
using System.Data;
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
        public void GetSkipTopFiveRecords(List<ProductReview> list)
        {
            var result = list.OrderByDescending(x => x.Rating).Skip(5).ToList();
            Display(result);
        }
        public void CreateDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductID");
            dt.Columns.Add("UserID");
            dt.Columns.Add("Review");
            dt.Columns.Add("Rating");
            dt.Columns.Add("IsLike");
            
            dt.Rows.Add("1", "1", "Nice", "5", "True");
            dt.Rows.Add("2", "1", "Nice", "4", "True");
            dt.Rows.Add("3", "1", "Average", "4", "True");
            dt.Rows.Add("4", "2", "Bad", "3", "False");
            dt.Rows.Add("5", "2", "Nice", "5", "True");
            dt.Rows.Add("6", "2", "Good", "2", "True");
            dt.Rows.Add("7", "3", "Average", "3", "True");
            dt.Rows.Add("8", "3", "Bad", "2", "False");
            dt.Rows.Add("9", "4", "Nice", "5", "True");
            dt.Rows.Add("10", "4", "Good", "4", "True");
            dt.Rows.Add("11", "4", "Average", "3", "True");
            dt.Rows.Add("12", "4", "Bad", "1", "False");
            dt.Rows.Add("13", "5", "Nice", "5", "True");
            dt.Rows.Add("14", "5", "Nice", "4", "True");
            dt.Rows.Add("15", "6", "Nice", "3", "True");
            dt.Rows.Add("16", "6", "Bad", "5", "False");
            dt.Rows.Add("17", "7", "Nice", "5", "True");
            dt.Rows.Add("18", "7", "Good", "2", "True");
            dt.Rows.Add("19", "7", "Average", "3", "True");
            dt.Rows.Add("20", "8", "Bad", "2", "False");
            dt.Rows.Add("21", "8", "Nice", "3", "True");
            dt.Rows.Add("22", "9", "Good", "4", "True");
            dt.Rows.Add("23", "8", "Average", "3", "True");
            dt.Rows.Add("24", "6", "Bad", "2", "False");
            dt.Rows.Add("25", "4", "Nice", "5", "True");
            
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine($"\n{dr["ProductId"]}\t{dr["UserId"]}\t{dr["Review"]}\t{dr["Rating"]}\t{dr["Islike"]}");
            }
        }
    }
}
