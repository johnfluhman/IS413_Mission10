using System;
using System.Linq;

namespace Mission07.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
