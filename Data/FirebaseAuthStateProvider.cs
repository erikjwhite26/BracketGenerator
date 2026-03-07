using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System.Security.Claims;

namespace BlazorApp.Data;

public class FirebaseAuthStateProvider : AuthenticationStateProvider
{
    private readonly IJSRuntime _js;

    private ClaimsPrincipal _currentUser = new(new ClaimsIdentity());
    private bool _isInitialized = false;

    public bool IsInitialized => _isInitialized;

    public FirebaseAuthStateProvider(IJSRuntime js)
    {
        _js = js;
        _js.InvokeVoidAsync("onAuthStateChanged", DotNetObjectReference.Create(this));
    }

    [JSInvokable]
    public void AuthStateChanged(string? uid, Dictionary<string, object>? claims)
    {
        if (string.IsNullOrEmpty(uid))
        {
            _currentUser = new ClaimsPrincipal(new ClaimsIdentity());
        }
        else
        {
            var claimList = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, uid)
            };

            if (claims != null)
            {
                foreach (var kvp in claims)
                {
                    claimList.Add(new Claim(kvp.Key, kvp.Value.ToString() ?? ""));
                }

                // Map Firebase custom claim "admin" to Blazor role "Admin"
                if (claims.TryGetValue("admin", out var isAdmin) &&
                    isAdmin?.ToString() == "True")
                {
                    claimList.Add(new Claim(ClaimTypes.Role, "Admin"));
                }
            }

            _currentUser = new ClaimsPrincipal(
                new ClaimsIdentity(claimList, "firebase"));
        }

        _isInitialized = true;
        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }

    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        return Task.FromResult(new AuthenticationState(_currentUser));
    }
}