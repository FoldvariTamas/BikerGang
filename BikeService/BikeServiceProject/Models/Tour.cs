using BikeServiceProject.Enums;

namespace BikeServiceProject.Models;

public record Tour(int ID, string Name, TourType Type, TourDifficulty Difficulty, DateTime Start, DateTime End, List<Person> Participants);