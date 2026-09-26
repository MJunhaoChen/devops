using DevOps.Strategies;
using DevOps.Strategies.Behaviours;

namespace DevOps.Domain.Roles {
    public class Developer : Person {
        public IRoleStrategy RoleStrategy { get; set; }

        public Developer() {
            RoleStrategy = new Coding();
        }

        public void Work() {
            RoleStrategy.PerformRole();
            mediaAdapter.SendNotification("Developer is working...");
        }

        public override void SendNotification(string message) {
            mediaAdapter.SendNotification(message);
        }
    }
}
