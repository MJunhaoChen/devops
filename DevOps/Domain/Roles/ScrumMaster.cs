using DevOps.Strategies;
using DevOps.Strategies.Behaviours;

namespace DevOps.Domain.Roles {
    public class ScrumMaster : Person {
        public IRoleStrategy RoleStrategy { get; private set; }

        public ScrumMaster() {
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
