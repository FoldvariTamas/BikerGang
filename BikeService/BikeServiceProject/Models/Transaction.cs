namespace BikeServiceProject.Models;

public record Transaction(int ID, int TotalPrice, StandardUser User, List<Part> PurchasedItems);