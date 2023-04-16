using WebApplication3.Types.BookType;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<BookQuery>();
var app = builder.Build();
app.MapGraphQL();

app.MapGet("/", () => "Hello World!");

app.Run();