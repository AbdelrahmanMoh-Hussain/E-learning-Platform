﻿using E_learning_Platform.Data.Repository.Interfaces;
using E_learning_Platform.Models;
using Microsoft.EntityFrameworkCore;

namespace E_learning_Platform.Data.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly ApplicationDbContext _context;

        public CartRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        

        public IEnumerable<Course?> GetUserCartCourses(int userId)
        {
            var coursesId = _context.UserCoursesCart.Where(c => c.UserId == userId)
                                .Select(c => c.CourseId)
                                .ToList();

            List<Course> courses = new List<Course>();
            foreach (var c in coursesId)
            {
                var course = _context.Course.Find(c);
                if(course is not null) 
                    courses.Add(course);

            }
            return courses;
        }

        public async Task<bool> RemoveCourseFromUserCartAsync(int courseId, int userId)
        {
            _context.UserCoursesCart.Remove(new UserCoursesCart { CourseId = courseId, UserId = userId });
            var effectedRows = await _context.SaveChangesAsync();
            return effectedRows > 0;
        }
        public async Task<bool> AddToCartAsync(int courseId, int userId)
        {
            var cart = new UserCoursesCart{ CourseId = courseId, UserId = userId };
            if (_context.UserCoursesCart.Contains(cart))
            {
                return false;
            }
            await _context.UserCoursesCart.AddAsync(new UserCoursesCart { CourseId = courseId, UserId = userId });
            var effectedRows = await _context.SaveChangesAsync();
            return effectedRows > 0;
        }

    }
}
