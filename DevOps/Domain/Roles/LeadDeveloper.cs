using DevOps.Strategies;
using DevOps.Strategies.Behaviours;

namespace DevOps.Domain.Roles {
    public class LeadDeveloper : Person {
        public IRoleStrategy RoleStrategy { get; set; }

        public LeadDeveloper() {
            RoleStrategy = new Managing();
        }

        public void Work() {
            RoleStrategy.PerformRole();
        }

        public override void SendNotification(string message) {
            mediaAdapter.SendNotification(message);
        }
    }
}
