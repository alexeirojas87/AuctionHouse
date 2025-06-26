using AuctionHouse.Domain.Bid;
using Xunit;

namespace AuctionHouse.UnitTests;

public class BidTests
{
    [Fact]
    public void Bid_CanBeInstantiated()
    {
        var bid = new Bid();
        Assert.NotNull(bid);
    }
}
