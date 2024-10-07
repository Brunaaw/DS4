namespace Domain
{
    public interface IQuoteRepository
    {
        Quote GetRandomQuote();
        List<Quote> GetAllQuotes();
        void AddQuote(Quote quote);
    }
}
