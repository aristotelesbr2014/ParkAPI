using System.Collections.Generic;

namespace ParkyAPI.Models.Repository.IRepository
{
    public interface INationalRepository
    {
        ICollection<NationalPark> GetNationalParks();

        NationalPark GetNationalPark(int nationalPark);

        bool NationalParkExists(string name);

        bool NationalParkExists(int id);

        bool CreateNationalPark(NationalPark nationalPark);

        bool UpdateNationalPark(NationalPark nationalPark);

        bool DeleteNationalPark(NationalPark nationalPark);

        bool Save();
    }
}
