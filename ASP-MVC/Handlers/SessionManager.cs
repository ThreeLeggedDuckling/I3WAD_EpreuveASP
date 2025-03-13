using System.Text.Json;

namespace ASP_MVC.Handlers
{
    public class SessionManager
    {
        private readonly ISession _session;
        public SessionManager(IHttpContextAccessor httpContextAccessor)
        {
            _session = httpContextAccessor.HttpContext.Session;
        }

        public ConnectedUser? ConnectedUser
        {
            get { return JsonSerializer.Deserialize<ConnectedUser?>(_session.GetString(nameof(ConnectedUser)) ?? "null"); }
            set
            {
                if (value is null) _session.Remove(nameof(ConnectedUser));
                else _session.SetString(nameof(ConnectedUser), JsonSerializer.Serialize(value));
            }
        }

    }
}
