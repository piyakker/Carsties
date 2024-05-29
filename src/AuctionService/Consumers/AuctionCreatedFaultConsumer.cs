using Contracts;
using MassTransit;

namespace AuctionService;

public class AuctionCreatedFaultConsumer : IConsumer<Fault<AuctionCreated>>
{
    public async Task Consume(ConsumeContext<Fault<AuctionCreated>> context)
    {
        Console.WriteLine("-->Consuming faulty cration");

        var exception = context.Message.Exceptions.First();

        if (exception.ExceptionType == "System.ArgumentException")
        {
            context.Message.Message.Model = "FooBar";
            // 這邊會隨著Fault帶入的event型別而自動帶入，所以才會自動是AuctionCreated，
            // 也因此會fanout給search-auction-created
            await context.Publish(context.Message.Message);
        }
        else
        {
            Console.WriteLine("Not an ArgumentException, doing nothing");
        }
    }
}
