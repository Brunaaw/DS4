using Domain;
using System;
using System.Collections.Generic;

namespace Infrastructure
{
    public class InMemoryQuoteRepository : IQuoteRepository
    {
        private List<Quote> _quotes = new List<Quote>
        {
            new Quote { Id = 1, Author = "Albert Einstein", Content = "Life is like riding a bicycle." },
            new Quote { Id = 2, Author = "Yoda", Content = "Do, or do not. There is no try." }
        };

        public Quote GetRandomQuote()
        {
            var random = new Random();
            int index = random.Next(_quotes.Count);
            return _quotes[index];
        }

        public List<Quote> GetAllQuotes()
        {
            return _quotes;
        }

        public void AddQuote(Quote quote)
        {
            _quotes.Add(quote);
        }
    }
}
