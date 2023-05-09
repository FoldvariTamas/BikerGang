using BikeService.Enums;

namespace BikeService.Models;

public record BikeNews(int ID, BikeNewsType Type, string PictureLink, string Description);