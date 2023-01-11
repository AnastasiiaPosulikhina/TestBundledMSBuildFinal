namespace OrleansApplication1.Server.IntegrationTest.Fixtures;

using Orleans.Hosting;
using Orleans.TestingHost;
using OrleansApplication1.Abstractions.Constants;

public class TestSiloConfigurator : ISiloConfigurator
{
    public void Configure(ISiloBuilder siloBuilder) =>
        siloBuilder
            .AddMemoryGrainStorageAsDefault()
            .AddMemoryGrainStorage("PubSubStore")
            .AddSimpleMessageStreamProvider(StreamProviderName.Default);
}