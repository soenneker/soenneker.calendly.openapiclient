using Soenneker.Tests.HostedUnit;

namespace Soenneker.Calendly.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CalendlyOpenApiClientTests : HostedUnitTest
{
    public CalendlyOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
