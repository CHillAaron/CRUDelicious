using CRUDelicious.CORE;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDelicious.DAL
{
    public class DishService
    { 
        CrudeliciousDbContext _context { get; } 

        public DishService(CrudeliciousDbContext context)
        {
            _context = context;
        }
        public List<Dishes> GetAll()
        {
            return _context.Dishes.ToList<Dishes>();
        }
        public Dishes GetItem(int id)
        {
            return _context.Dishes.Where(thisItem => thisItem.DishId == id).FirstOrDefault();
        }
        public void AddItem(Dishes newItem)
        {
            _context.Dishes.Add(newItem);
            _context.SaveChanges();
        }
        public void UpdateItem(Dishes updateItem)
        {
            _context.Dishes.Update(updateItem);
            _context.SaveChanges();
        }
        public void DeleteTodoItem(int id)
        {
            _context.Dishes.Remove(GetItem(id));
            _context.SaveChanges();
        }
    }
}
