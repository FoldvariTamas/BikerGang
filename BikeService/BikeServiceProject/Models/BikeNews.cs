using BikeServiceProject.Enums;

namespace BikeServiceProject.Models;

public record BikeNews(int ID, BikeNewsType Type, string PictureLink, string Description);