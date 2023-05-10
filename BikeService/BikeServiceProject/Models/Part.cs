namespace BikeServiceProject.Models;

public record Part(int ID, string Make, string Model, int Price, string Description, List<Bike> Compatibility);