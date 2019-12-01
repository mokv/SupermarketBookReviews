using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Supermarket.MVC.Models;
using Supermarket.MVC.Services;

namespace Supermarket.MVC.Controllers
{
    public class ReviewController : Controller
    {
        IReviewsService reviewsService;

        public ReviewController(IReviewsService _reviewsService)
        {
            reviewsService = _reviewsService;
        }

        public IActionResult Create(int bookId)
        {
            var newReview = new Review() { BookId = bookId };
            return View(newReview);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Review review)
        {
            review.UserId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await reviewsService.CreateReview(review);
            return RedirectToAction("Details", "Books", new { id = review.BookId });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int reviewId, int bookId)
        {
            await reviewsService.DeleteReview(reviewId);
            return RedirectToAction("Details", "Books", new { id = bookId });
        }
    }
}