public static class Billing
{
    public static double CalculateTotalBill(Tenant tenant)
    {
        double staticElectricityBill = 200;  // Static monthly electricity bill
        double staticWaterBill = 400;  // Static monthly water bill
        double rentPerMonth = Tenant.Rent;

        double totalElectricityBill = staticElectricityBill * tenant.Duration;
        double totalWaterBill = staticWaterBill * tenant.Duration;
        double totalRent = rentPerMonth * tenant.Duration;

        double totalBill = totalRent + totalElectricityBill + totalWaterBill;
        return totalBill;
    }
}
