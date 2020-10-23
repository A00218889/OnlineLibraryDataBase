using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineLibrary.Data
{
    public class BookService
    {
        private readonly ApplicationDbContext _dbContext;

        public BookService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Book>> GetBooksAsync()
        {
            return await _dbContext.Book.ToListAsync();
        }

        public async Task<Book> GetBookAsync(int bookId)
        {
            return await _dbContext.Book.FirstOrDefaultAsync(book => book.BookId == bookId);
        }

        public async Task<bool> RemoveBookAsync(int bookId)
        {
            var book = await _dbContext.Book.FirstOrDefaultAsync(book => book.BookId == bookId);
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

        public async Task<bool> AddBookAsync(Book book)
        {
            await _dbContext.Book.AddAsync(book);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}