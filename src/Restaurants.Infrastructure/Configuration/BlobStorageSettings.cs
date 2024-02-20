namespace Restaurants.Infrastructure.Configuration;

public class BlobStorageSettings
{
    public string ConnectionString { get; set; } = default!;
    public string LogosContainerName { get; set; } = default!;
    public string AccountKey { get; set; } = default!;
}
