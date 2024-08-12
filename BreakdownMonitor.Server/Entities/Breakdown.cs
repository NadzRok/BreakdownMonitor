using System;
using System.Collections.Generic;

namespace BreakdownMonitor.Server.Entities;

public class Breakdown
{
    public int Id { get; set; }

    public Guid BreakdownReference { get; set; }

    public string CompanyName { get; set; } = null!;

    public string DriverName { get; set; } = null!;

    public string RegistrationNumber { get; set; } = null!;

    public DateTime BreakdownDate { get; set; }
}
