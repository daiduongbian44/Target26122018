using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC01_BlogAndPost.Services.Interfaces
{
    public interface IBaseService<T>
    {
        List<T> GetList();

        bool AddNew(T data);
    }
}
