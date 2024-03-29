using System.Collections.Generic;
using chat_application.Identity;

namespace chat_application.Models
{
    public class DashboardModel
    {
        public List<AppIdentityUser> users { get; set; }
        public List<Message> messages { get; set; }
        public List<Group> groups { get; set; }
        public List<Group> memberGroups { get; set; }
        public string currentUserName { get; set; }
    }
}