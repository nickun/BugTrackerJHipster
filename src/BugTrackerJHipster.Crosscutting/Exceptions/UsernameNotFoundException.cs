using System.Security.Authentication;

namespace BugTracker.Crosscutting.Exceptions
{
    public class UsernameNotFoundException : AuthenticationException
    {
        public UsernameNotFoundException(string message) : base(message)
        {
        }
    }
}
