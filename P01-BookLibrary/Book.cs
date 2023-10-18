using System;
namespace P01_BookLibrary
{
	public class Book
	{
        private List<string> authors;
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            this.authors = authors.ToList();
        }

        public string Title { get; set; }

		public int Year { get; set; }

		public IReadOnlyCollection<string> Authors { get { return authors; } }




	}
}

