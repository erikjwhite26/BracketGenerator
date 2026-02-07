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
    public void AuthStateChanged(string? uid)
    {
        if (string.IsNullOrEmpty(uid))
        {
            _currentUser = new ClaimsPrincipal(new ClaimsIdentity());
        }
        else
        {
            _currentUser = new ClaimsPrincipal(
                new ClaimsIdentity(
                    [new Claim(ClaimTypes.NameIdentifier, uid)],
                    "firebase"));
        }

        _isInitialized = true;
        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }

    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        return Task.FromResult(new AuthenticationState(_currentUser));
    }
}