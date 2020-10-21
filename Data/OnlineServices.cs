/*
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace OnlineLibrary.Data
{   
    public class OnlineServices
    {
        private readonly ApplicationDbContext _dbContext;
        public OnlineServices(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Book>>GetBooksAsync()
        {
            return await _dbContext.Book.ToListAsync(); 

        }
        public async Task<Book>GetBookAsync(int bookId)
        {
            return await _dbContext.Book.FirstOrDefaultAsync(book => book.BookID == bookId);

        }
        public async Task<bool> RemoveBookAsync(int bookId)
        {
            var book = await _dbContext.Book.FirstOrDefaultAsync(book => book.BookID == bookId);
            _dbContext.Book.Remove(book);
            await _dbContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateBookAsync(Book book)
        {
             _dbContext.Book.Update(book);
            await _dbContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> AddOnlineAccessAsync(OnlineAccess _onlineAccess)
        {
            await _dbContext.OnlineAccess.AddAsync(_onlineAccess);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
*/