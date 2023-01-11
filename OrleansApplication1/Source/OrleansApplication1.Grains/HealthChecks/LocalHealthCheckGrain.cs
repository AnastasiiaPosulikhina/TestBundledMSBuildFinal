namespace OrleansApplication1.Grains;

using Orleans;
using Orleans.Concurrency;
using OrleansApplication1.Abstractions.Grains.HealthChecks;

[StatelessWorker(1)]
public class LocalHealthCheckGrain : Grain, ILocalHealthCheckGrain
{
    public ValueTask CheckAsync() => ValueTask.CompletedTask;
}