using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IHttpService
    {
        Task<T> Get<T> (string url);
        Task<T> Get<T>(string url, int Id);
        Task<T> Post<T> (string url, T obj);
        Task<T> Put<T> (string url, T obj);
        Task<T> Delete<T> (string url, int Id);
    }
}
