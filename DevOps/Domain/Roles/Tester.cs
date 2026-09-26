using DevOps.Strategies;
using DevOps.Strategies.Behaviours;

namespace DevOps.Domain.Roles {
    public class Tester : Person {
        public IRoleStrategy RoleStrategy { get; set; }

        public Tester() {
            RoleStrategy = new Testing();
        }

        public void Work() {
            RoleStrategy.PerformRole();
        }

        public override void SendNotification(string message) {
            mediaAdapter.SendNotification(message);
        }
    }
}
