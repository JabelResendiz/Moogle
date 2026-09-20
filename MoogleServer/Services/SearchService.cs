using MoogleEngine;

namespace MoogleServer.Services;

public sealed class SearchService
{
    public SearchResult Search(string query)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(query);

        return Moogle.Query(query.Trim());
    }
}