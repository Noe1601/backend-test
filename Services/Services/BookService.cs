using Microsoft.Extensions.Configuration;
using Services.Dtos;
using Services.Enums;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class BookService : IBookService
    {
        private readonly IHttpService _httpService;
        private readonly string _url;

        public BookService(IHttpService httpService, IConfiguration configuration)
        {
            _httpService = httpService;
            _url = configuration.GetSection(Configurations.ApiUrl.ToString()).Value!;
        }

        public async Task<List<BookDto>> Get()
        {
            var results = await _httpService.Get<List<BookDto>>(_url);
            return results;
        }
        public async Task<BookDto> GetById(int Id)
        {
            var results = await _httpService.Get<BookDto>(_url, Id);
            return results;
        }

        public async Task<BookDto> Delete(int Id)
        {
            var results = await _httpService.Delete<BookDto>(_url, Id);
            return results;
        }

        public async Task<BookDto> Post(BookDto bookDto)
        {
            var results = await _httpService.Post<BookDto>(_url, bookDto);
            return results;
        }

        public async Task<BookDto> Update(BookDto bookDto)
        {
            var results = await _httpService.Put<BookDto>(_url, bookDto);
            return results;
        }

    }
}
