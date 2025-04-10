using System;
using MyWebApp.DataAccess.Repositories.IRepository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebApp.DataAccess.Repository;
using MyWebApp.DataAccess.Data;
using MyWebApp.Models;

namespace MyWebApp.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
         private readonly ApplicationDbContext _db;
         public ICategoryRepository Category {get; private set;}
        
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
        }

    public void Save()
    {
            _db.SaveChanges();
        }
    }
}
