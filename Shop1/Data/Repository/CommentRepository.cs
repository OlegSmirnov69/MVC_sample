using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop1.Data.Interfaces;
using Shop1.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Shop1.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Shop1.Controllers;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Shop1.Data.Repository
{
    public class CommentRepository : IComments
    {

        private readonly UserContext userContext;
        private readonly Comment comment;

        public CommentRepository(UserContext userCont, Comment comm)
        {
            this.userContext = userCont;
            this.comment = comm;
        }
        //-----------------------------------

    

        //----------------------------------


        public void createComment(Comment comment)
        {
            comment.date = DateTime.Now;
            userContext.Comments.Add(comment);
            comment.text = "FirstComment";
        }
    }
}
