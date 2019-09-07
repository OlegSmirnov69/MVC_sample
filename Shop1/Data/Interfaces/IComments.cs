using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop1.Data.Models;

namespace Shop1.Data.Interfaces
{
    public interface IComments
    {
       // IEnumerable<Comment> GetComments { get; }
        void createComment(Comment comment);
    }
}
