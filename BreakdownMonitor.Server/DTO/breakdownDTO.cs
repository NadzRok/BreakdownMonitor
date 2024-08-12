namespace BreakdownMonitor.Server.DTO {
    public class breakdownDTO {
        public int Id { get; set; }

        public Guid BreakdownReference { get; set; }

        public string CompanyName { get; set; } = null!;

        public string DriverName { get; set; } = null!;

        public string RegistrationNumber { get; set; } = null!;

        public string BreakdownDate { get; set; }
    }
}
