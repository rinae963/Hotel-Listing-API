using HotelListing.API.Contracts;
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Repository
{
    // :Inherits from
    //This is the actual implementation of our contract
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly HotelListingDbContext _context;

        public GenericRepository(HotelListingDbContext context)
        {
            this._context = context;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _context.AddAsync(entity); 
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync (id);   
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            //get the entity and return the entiyi if its not null(true if exists)
            var entity = await GetAsync(id);
            return entity != null; 
        }

        public async Task<List<T>> GetAllAsync()
        {

            var results=_context.Set<T>().ToList();
            //The reason why we had to wait is because we have asynchronised method.  
            //Go to the Db and get the Dbset that is associated with T 
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int? id)
        {
            if(id is null)
            {
                return null;
            }
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            //update the context then save the changes
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        Task IGenericRepository<T>.AddAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
