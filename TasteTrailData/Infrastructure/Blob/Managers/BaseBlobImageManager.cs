using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Storage.Blobs;

namespace TasteTrailData.Infrastructure.Blob.Managers;

public abstract class BaseBlobImageManager
{
    protected readonly BlobServiceClient _blobServiceClient;
    protected readonly string _containerName;

    protected BaseBlobImageManager(BlobServiceClient blobServiceClient, string containerName)
    {
        _blobServiceClient = blobServiceClient;
        _containerName = containerName;
    }

    public string GetDefaultImageUrl()
    {
        var containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
        var defaultImageBlobName = "default-image.png";

        var blobClient = containerClient.GetBlobClient(defaultImageBlobName);
        
        if (!blobClient.Exists())
            throw new InvalidOperationException("Default image does not exist in Blob Storage.");

        return blobClient.Uri.ToString();
    }
}