namespace DevOps.Decorators {
    public abstract class ReportDecorator : IReport {
        protected IReport report;

        protected ReportDecorator(IReport report) {
            this.report = report;
        }

        public virtual void GenerateReport() {
            report.GenerateReport();
        }
    }
}
