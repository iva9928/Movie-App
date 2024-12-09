﻿

namespace MovieApp.Data.Repository
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;
    using MovieApp.Data.Repository.Interfaces;
    public class Repository<TType, TId> : IRepository<TType, TId>
        where TType : class
    {
        
        private readonly MovieAppDbContext dbContext;
        private readonly DbSet<TType> dbSet;


        public Repository(MovieAppDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = this.dbContext.Set<TType>();   
        }
       
        public void Add(TType item)
        {
            this.Add(item);
            this.dbContext.SaveChanges();
        
        }

        public async Task AddAsync(TType item)
        {
           await this.dbSet.AddAsync(item);
            this.dbContext.SaveChangesAsync();

        }

        public bool Delete(TId id)
        {
            TType entity = this.GetById(id);
            if (entity == null)
            {
                return false;
            }
            this.dbSet.Remove(entity);
            this.dbContext.SaveChanges(); 
            
            return true;  
     
        }

        public async Task<bool> DeleteAsync(TId id)
        {
            TType entity = await this.GetByIdAsync(id);
            if (entity == null)
            {
                return false;
            }
            this.dbSet.Remove(entity);
            this.dbContext.SaveChangesAsync();

            return true;
        }

        public IEnumerable<TType> GetAll()
        {
            return this.dbSet.ToArray();    
        }

        public async Task<IEnumerable<TType>> GetAllAsync()
        {
            return await this.dbSet.ToArrayAsync();

        }

        public IEnumerable<TType> GetAllAttached()
        {
            return this.dbSet.AsQueryable();
        }

        public TType GetById(TId id)
        {
            TType entity = this.dbSet
                 .Find(id);

            return entity;
        }

        public async Task<TType> GetByIdAsync(TId id)
        {
            TType entity = await this.dbSet
                .FindAsync(id);

            return entity;
        }
        
        public bool Update(TType item)
        {
            try
            {
                this.dbSet.Attach(item);
                this.dbContext.Entry(item).State = EntityState.Modified;
                this.dbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool> UpdateAsync(TType item)
        {

            try
            {
                this.dbSet.Attach(item);
                this.dbContext.Entry(item).State = EntityState.Modified;
                await this.dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

       
    }
}
