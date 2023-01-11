namespace OrleansApplication1.Grains.HealthChecks;

using Orleans;
using Orleans.Placement;
using Orleans.Runtime;
using OrleansApplication1.Abstractions.Grains.HealthChecks;

[PreferLocalPlacement]
public class StorageHealthCheckGrain : Grain<Guid>, IStorageHealthCheckGrain
{
    public async ValueTask CheckAsync()
    {
        try
        {
            this.State = Guid.NewGuid();
            await this.WriteStateAsync().ConfigureAwait(true);
            await this.ReadStateAsync().ConfigureAwait(true);
            await this.ClearStateAsync().ConfigureAwait(true);
        }
        finally
        {
            this.DeactivateOnIdle();
        }
    }
}