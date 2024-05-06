public class Tenant
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Apartment { get; set; }
    public int Duration { get; set; }  // Duration of the lease in months
    public static double Rent { get; } = 4500;  // Monthly rent, static
    public double ElectricityUsage { get; set; }  // kWh
    public double WaterUsage { get; set; }  // Cubic meters

    // Constructor
    public Tenant(string username, string password, string apartment, int duration)
    {
        Username = username;
        Password = password;
        Apartment = apartment;
        Duration = duration;
    }
}
