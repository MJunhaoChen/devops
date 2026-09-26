using DevOps.Strategies;
using DevOps.Strategies.Behaviours;

namespace DevOps.Domain.Roles {
    public class ProductOwner : Person {
        public IRoleStrategy RoleStrategy { get; set; }

        public ProductOwner() {
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

