namespace OrleansApplication1.Abstractions.Grains.HealthChecks;

using Orleans;

public interface IStorageHealthCheckGrain : IGrainWithGuidKey
{
    ValueTask CheckAsync();
}