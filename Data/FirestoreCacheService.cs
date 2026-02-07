namespace BlazorApp.Data;

public class FirestoreCacheService
{
    private readonly Dictionary<string, object> _cache = [];

    public async Task<T> GetCachedAsync<T>(string key, Func<Task<T>> fetch)
    {
        if (_cache.TryGetValue(key, out var cached))
            return (T)cached;

        var result = await fetch();
        _cache[key] = result;
        return result;
    }
}