using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.MongoDb;
using Abp.MongoDb.Repositories;

namespace MyProject.MongoDB.Repositories
{
    public class BookRepository : MongoDbRepositoryBase<Book, Guid>, IBookRepository
    {
        public BookRepository(IMongoDatabaseProvider databaseProvider)
            : base(databaseProvider)
        {
        }
    }
}
