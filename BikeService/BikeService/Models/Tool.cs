using BikeService.Enums;

namespace BikeService.Models;

public record Tool(int ID, ToolType Type, List<ServiceEventType> ServiceEventCompatibility);