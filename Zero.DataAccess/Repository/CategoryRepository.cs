using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Zero.DataAccess.Data;
using Zero.DataAccess.Repository.IRepository;
using Zero.Models;

namespace Zero.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category> ,ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;   
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
