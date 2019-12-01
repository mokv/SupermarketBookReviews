using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Supermarket.MVC.Data;
using Supermarket.MVC.Models;

namespace Supermarket.MVC.Services
{
    public class ReviewsService : IReviewsService
    {
        private ApplicationDbContext dbContext;

        public ReviewsService(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public async Task CreateReview(Review review)
        {
            await dbContext.Reviews.AddAsync(review);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteReview(int id)
        {
            var review = await dbContext.Reviews.FindAsync(id);
            dbContext.Reviews.Remove(review);
            await dbContext.SaveChangesAsync();
        }
    }
}
