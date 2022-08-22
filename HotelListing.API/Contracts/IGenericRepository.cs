﻿namespace HotelListing.API.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        //This one is supposed to return one record
        Task<T> GetAsync(int? id);
        Task <List<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
        Task<bool> Exists(int id);
    }
}
 