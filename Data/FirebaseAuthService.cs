using Microsoft.JSInterop;

namespace BlazorApp.Data;

public class FirebaseAuthService(IJSRuntime js)
{
    private readonly IJSRuntime _js = js;

    public ValueTask Register(string email, string password) =>
        _js.InvokeVoidAsync("register", email, password);

    public ValueTask Login(string email, string password) =>
        _js.InvokeVoidAsync("login", email, password);

    public ValueTask Logout() =>
        _js.InvokeVoidAsync("logout");

    public ValueTask SendPasswordResetEmail(string email) =>
        _js.InvokeVoidAsync("resetPassword", email);
}