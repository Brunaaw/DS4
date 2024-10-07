using Domain;

namespace Application
{
    public class QuoteService
    {
        private readonly IQuoteRepository _quoteRepository;

        public QuoteService(IQuoteRepository quoteRepository)
        {
            _quoteRepository = quoteRepository;
        }

        public Quote GetRandomQuote()
        {
            return _quoteRepository.GetRandomQuote();
        }

        public void AddQuote(Quote quote)
        {
            _quoteRepository.AddQuote(quote);
        }

        public List<Quote> GetAllQuotes()
        {
            return _quoteRepository.GetAllQuotes();
        }
    }
}
