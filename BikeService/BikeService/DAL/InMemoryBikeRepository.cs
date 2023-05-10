
using BikeService.Models;

namespace BikeService.DAL;

public class InMemoryBikeRepository : IRepository<Bike>
{
    private readonly HashSet<Bike> _bikes;

    public InMemoryBikeRepository()
    {
        _bikes = new HashSet<Bike>();
    }

    public HashSet<Bike> GetAll()
    {
        return _bikes;
    }

    public Bike GetById(int id)
    {
        return _bikes.FirstOrDefault(bike => bike.Id == id)!;
    }

    public void Create(Bike bike)
    {
        _bikes.Add(bike);
    }

    public void Update(Bike bike)
    {
        var bikeToUpdate = GetById(bike.Id);

        bikeToUpdate.State = bike.State;
        bikeToUpdate.Type = bike.Type;
        bikeToUpdate.Model = bike.Model;
        bikeToUpdate.Manufacturer = bike.Manufacturer;
        bikeToUpdate.VIN = bike.VIN;
        bikeToUpdate.Insured = bike.Insured;
        bikeToUpdate.FrameSize = bike.FrameSize;
        bikeToUpdate.WheelSize = bike.WheelSize;
        bikeToUpdate.ServiceHistory = bike.ServiceHistory;
    }

    public void Delete(int id)
    {
        _bikes.Remove(GetById(id));
    }
}