import { UUID } from "crypto";

export interface Breakdown {
    id: number;
    BreakdownReference: UUID;
    CompanyName: string;
    DriverName: string;
    RegistrationNumber: string;
    BreakdownDate: string;
}