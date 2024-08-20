using FeatureSlices.Features.Books.CreateBook;
using FeatureSlices.Features.Books.DeleteBook;
using FeatureSlices.Features.Books.GetBooks;
using FeatureSlices.Features.Books.UpdateBook;

namespace FeatureSlices.Features.Books
{
    public static class BookEndpoints
    {
        public static void MapBookEndpoints(this WebApplication app)
        {
            app.MapCreateBookEndpoints();
            app.MapGetBooksEndpoints();
            app.MapDeleteBookEndpoints();
            app.MapUpdateBookEndpoints();
        }

        public static void AddBookServices(this IServiceCollection services)
        {
            services.AddCreateBookServices();
            services.AddGetBooksServices();
            services.AddDeleteBookServices();
            services.AddUpdateBookServices();
        }
    }
}
