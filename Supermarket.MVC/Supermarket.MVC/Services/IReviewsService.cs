using Supermarket.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.MVC.Services
{
    public interface IReviewsService
    {
        Task CreateReview(Review review);

        Task DeleteReview(int id);
    }
}
