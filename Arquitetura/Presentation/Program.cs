using Application;
using Infrastructure;
using Domain;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IQuoteRepository, InMemoryQuoteRepository>();
builder.Services.AddTransient<QuoteService>();

var app = builder.Build();

app.MapGet("/quote", (QuoteService quoteService) => quoteService.GetRandomQuote());
app.MapGet("/quotes", (QuoteService quoteService) => quoteService.GetAllQuotes());
app.MapPost("/quote", (QuoteService quoteService, Quote quote) => quoteService.AddQuote(quote));

app.Run();
