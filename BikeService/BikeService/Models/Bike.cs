using BikeService.Enums;

namespace BikeService.Models;

public record Bike(int ID, string VIN, string Manufacturer, string Model, BikeTypes Type, int WheelSize, BikeFrameSize FrameSize, BikeState State, List<ServiceEvent> ServiceHistory, bool Insured);