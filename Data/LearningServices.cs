using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace OnlineLibrary.Data
{   
    public class LearningServices
    {
        private readonly ApplicationDbContext _dbContext;
        public LearningServices(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Book>>GetBooksAsync()
        {
            return await _dbContext.Book.ToListAsync(); 

        }
    }
}
