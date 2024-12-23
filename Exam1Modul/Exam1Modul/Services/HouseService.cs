using Exam1Modul.Models;
using System.Numerics;

namespace Exam1Modul.Services;

internal class HouseService
{
    private List<House> houses;

    public HouseService()
    {
        houses = new List<House>();
    }

    public House AddHouse(House newHouse)
    {
        newHouse.Id = Guid.NewGuid();
        houses.Add(newHouse);

        return newHouse;
    }

    public House GetById(Guid id)
    {
        foreach (House houseDb in houses)
        {
            if (houseDb.Id == id)
            {
                return houseDb;
            }
        }
        return null;
    }

    public bool DeleteHouse(Guid id)
    {
        var houseFormat = GetById(id);

        if (houseFormat is null)
        {
            return false;
        }

        houses.Remove(houseFormat);
        return true;
    }

    public bool UpdateHouse(Guid id, House updatedHouse)
    {
        var houseFormat = GetById(id);

        if (houseFormat is null)
        {
            return false;
        }

        var index = houses.IndexOf(houseFormat);
        updatedHouse.Id = id;
        houses[index] = updatedHouse;
        return true;
    }

    public List<House> GetAll()
    {
        return houses;
    }
}
