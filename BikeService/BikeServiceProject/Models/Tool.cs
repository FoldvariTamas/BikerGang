using BikeServiceProject.Enums;

namespace BikeServiceProject.Models;

public record Tool(int ID, ToolType Type, List<ServiceEventType> ServiceEventCompatibility);