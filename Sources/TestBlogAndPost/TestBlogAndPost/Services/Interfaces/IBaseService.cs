using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBlogAndPost.Services.Interfaces
{
    public interface IBaseService<T>
    {
        List<T> GetLists();

        bool AddNew(T data);
    }
}
