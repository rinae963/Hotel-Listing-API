using HotelListing.API.Data;

namespace HotelListing.API.Contracts
{
    //mini contracts

    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
 