using Microsoft.EntityFrameworkCore;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Entities;
using ProductApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Persistence.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext applicationDbContext):base(applicationDbContext)
        {

        }

        public async Task<List<Product>> GetAllProduct()
        {
            throw new NotImplementedException();
            //return await dbContext.Products.ToListAsync();
        }

        public Task<Product> GetProductById()
        {
            throw new NotImplementedException();
        }
    }
}
