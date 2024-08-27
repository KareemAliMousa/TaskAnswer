namespace TaskAnswer.Services
{
    public interface IJwtTokenManager
    {
        string AuthenticateUser(string username, string password);
    }
}
