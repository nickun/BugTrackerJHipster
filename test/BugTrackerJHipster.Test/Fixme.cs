using BugTracker.Infrastructure.Data;
using BugTracker.Domain;
using BugTracker.Test.Setup;

namespace BugTracker.Test
{
    public static class Fixme
    {
        public static User ReloadUser<TEntryPoint>(AppWebApplicationFactory<TEntryPoint> factory, User user)
            where TEntryPoint : class
        {
            var applicationDatabaseContext = factory.GetRequiredService<ApplicationDatabaseContext>();
            applicationDatabaseContext.Entry(user).Reload();
            return user;
        }
    }
}
