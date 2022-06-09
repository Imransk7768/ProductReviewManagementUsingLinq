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

            foreach (var product in reviewList)
            {
                Console.WriteLine("");
                Console.WriteLine("PRODUCTID : "+ product.ProductId + ", USERID : " + product.UserId + ", RATING : " + product.Rating +
                    ", REVIEW : " + product.Review  + ", STATUS : " + product.IsLike);
            }
        }
    }
}