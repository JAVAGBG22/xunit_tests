using BookingApp.Core.Models;

namespace BookingApp.Core.Processors
{
    public class BookingRequestProcessor
    {
        public BookingRequestProcessor()
        {
        }

        public BookingResult Book(BookingRequest request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }


            return new BookingResult
            {
                FullName = request.FullName,
                Email = request.Email,
                DateOnly = request.DateOnly
            };
        }
    }
}