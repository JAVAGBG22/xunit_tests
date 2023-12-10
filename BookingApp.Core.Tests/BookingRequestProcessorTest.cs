using System;
using BookingApp.Core.Models;
using BookingApp.Core.Processors;
using Shouldly;
namespace BookingApp.Core.Tests
{
	public class BookingRequestProcessorTest
	{
        private BookingRequestProcessor _processor;

        // REQUIREMENTS
        // when a method is being called to process a booking
        // we expect a certain answer with all the booking details included

        public BookingRequestProcessorTest()
		{
			_processor = new BookingRequestProcessor();
		}

		[Fact]
		public void Should_Return_Booking_Response_With_Details()
		{
			// ARRANGE
			var request = new BookingRequest
			{
				FullName = "Test Name",
				Email = "test@gmail.com",
				DateOnly = new DateTime(2023, 12, 10)
			};

			// processor to handle the request
			//var processor = new BookingRequestProcessor();

			// ACT
			// method for processing the request
			BookingResult result = _processor.Book(request);

			// ASSERT

			// default xUnit
			Assert.NotNull(result);

			Assert.Equal(request.FullName, result.FullName);
            Assert.Equal(request.Email, result.Email);
            Assert.Equal(request.Email, result.Email);

            // shouldly
            result.ShouldNotBeNull();

			result.FullName.ShouldBe(request.FullName);
            result.Email.ShouldBe(request.Email);
            result.DateOnly.ShouldBe(request.DateOnly);

        }

		[Fact]
		public void Should_Throw_Exception_For_Null_Request()
		{
			//var processor = new BookingRequestProcessor();

			// shouldly
			var exception = Should.Throw<ArgumentNullException>(() => _processor.Book(null!));

			// default xUnit
			//Assert.Throws<ArgumentNullException>(() => processor.Book(null!));

			exception.ParamName.ShouldBe("request");
        }
	}
}









































