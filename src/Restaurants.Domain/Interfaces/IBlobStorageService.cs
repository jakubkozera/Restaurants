namespace Restaurants.Domain.Interfaces;

public interface IBlobStorageService
{
    string? GetBlobSasUrl(string? blobUrl);
    Task<string> UploadToBlobAsync(Stream data, string fileName);
}
