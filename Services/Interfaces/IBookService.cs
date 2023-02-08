using Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IBookService
    {
        Task<List<BookDto>> Get();

        Task<BookDto> GetById(int Id);

        Task<BookDto> Delete(int Id);

        Task<BookDto> Post(BookDto dto);

        Task<BookDto> Update(BookDto dto);

    }
}
