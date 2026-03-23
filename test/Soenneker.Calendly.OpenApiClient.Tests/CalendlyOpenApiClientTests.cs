using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Calendly.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class CalendlyOpenApiClientTests : FixturedUnitTest
{
    public CalendlyOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
