using BikeService.DAL;
using BikeService.Models;

namespace BikeService.Service;

public class BikeService : IBikeService
{
    private readonly IRepository<Bike> _bikeRepository;

    public BikeService(IRepository<Bike> bikeRepository)
    {
        _bikeRepository = bikeRepository;
    }

    public HashSet<Bike> GetAllBikes()
    {
       return _bikeRepository.GetAll();
    }

    public Bike GetBikeById(int id)
    {
        return _bikeRepository.GetById(id);
    }

    public void CreateBike(Bike bike)
    {
        _bikeRepository.Create(bike);
    }

    public void UpdateBike(Bike bike)
    {
        _bikeRepository.Update(bike);
    }

    public void DeleteBike(int id)
    {
        _bikeRepository.Delete(id);
    }
}