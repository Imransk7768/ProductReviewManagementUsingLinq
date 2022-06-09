using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product Review Management\n");
            List<ProductReview> reviewList = new List<ProductReview>();
            reviewList.Add(new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 2, UserId = 1, Rating = 4, Review = "Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 3, UserId = 1, Rating = 2, Review = "Good", IsLike = false });
            reviewList.Add(new ProductReview() { ProductId = 4, UserId = 2, Rating = 4, Review = "nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 5, UserId = 2, Rating = 1, Review = "Bad", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 6, UserId = 2, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 7, UserId = 3, Rating = 4, Review = "Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 8, UserId = 3, Rating = 2, Review = "Good", IsLike = false });
            reviewList.Add(new ProductReview() { ProductId = 9, UserId = 4, Rating = 4, Review = "Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 10, UserId = 4, Rating = 1, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 11, UserId = 4, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 12, UserId = 4, Rating = 4, Review = "Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 13, UserId = 5, Rating = 2, Review = "Good", IsLike = false });
            reviewList.Add(new ProductReview() { ProductId = 14, UserId = 5, Rating = 4, Review = "Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 15, UserId = 5, Rating = 1, Review = "Bad", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 16, UserId = 5, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 17, UserId = 6, Rating = 4, Review = "Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 18, UserId = 7, Rating = 2, Review = "Good", IsLike = false });
            reviewList.Add(new ProductReview() { ProductId = 19, UserId = 8, Rating = 4, Review = "Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 20, UserId = 8, Rating = 1, Review = "Bad", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 21, UserId = 9, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 22, UserId = 8, Rating = 4, Review = "Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 23, UserId = 9, Rating = 2, Review = "Good", IsLike = false });
            reviewList.Add(new ProductReview() { ProductId = 24, UserId = 7, Rating = 4, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 25, UserId = 2, Rating = 1, Review = "Bad", IsLike = true });

            bool check = true;
            Operations operations = new Operations();
            Console.WriteLine("1. Display Product Review\n2. Get top 3 Records\n3. Get Records By ProductId & Rating\n4. Count by ProductId\n" +
                "5. Get All Records By ProductId\n6. Skip Top Five Records\n7. Create DataTable\n8. Create Table form List" +
                "\n9. Retrieve Data where IsLike is True\n10. Avg Rating");
            while (check)
            {
                Console.Write("Select Option to Execute : ");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        operations.Display(reviewList);
                        break;
                    case 2:
                        operations.GetTopThreeRecords(reviewList);
                        break;
                    case 3:
                        operations.GetTopRecordsByProductIdRating(reviewList);
                        break;
                    case 4:
                        operations.GetRecordsCountByProductId(reviewList);
                        break;
                    case 5:
                        operations.GetAllRecordsProductId(reviewList);
                        break;
                    case 6:
                        operations.GetSkipTopFiveRecords(reviewList);
                        break;
                    case 7:
                        operations.CreateDataTable();
                        break;
                    case 8:
                        operations.CreateTableData(reviewList);
                        break;
                    case 9:
                        operations.RetriveRecordsByIsTrue(reviewList);
                        break;
                    case 10:
                        operations.GetAvgRating(reviewList);
                        break;
                    default:
                        Console.WriteLine("Program Ends.");
                        break;
                }
            }
        }
    }
}