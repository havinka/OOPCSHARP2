using System;
using System.Collections;

namespace P01_BookLibrary
{
	public class Library:IEnumerable<Book>
	{
        public Library(params Book[] books)
        {
            this.books = books.ToList();
        }

        public IReadOnlyList<Book> books { get; set; }



        public IEnumerator<Book> GetEnumerator()
        {
            for (int i = 0; i < books.Count; i++)
            {
                yield return books[i];
            }
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

