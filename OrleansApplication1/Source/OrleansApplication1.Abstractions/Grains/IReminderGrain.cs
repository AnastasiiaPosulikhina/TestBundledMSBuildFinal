namespace OrleansApplication1.Abstractions.Grains;

using Orleans;

public interface IReminderGrain : IGrainWithGuidKey
{
    ValueTask SetReminderAsync(string reminder);
}