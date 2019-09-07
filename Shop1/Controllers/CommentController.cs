using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop1.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Shop1.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Shop1.Controllers
{
    public class CommentController : Controller
    {

        private readonly UserContext userContext;
        private readonly Comment comment;

        public CommentController(UserContext userContext, Comment comment)
        {
            this.userContext = userContext;
            this.comment = comment;
        }

       // public IEnumerable<Comment> GetComments => userContext.Comments.Include(c => c.id);


        public void createComment(Comment comment)
        {
            comment.date = DateTime.Now;
            comment.text = "FirstComment";
            comment.user_name = "User1";
            comment.user_country = "USA1";


            userContext.Comments.Add(comment);

            userContext.SaveChanges();

        }

        public IActionResult AdComent()
        {
            return View();
        }

    }
}
