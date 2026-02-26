using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Hospital.Model;
using WPF.Hospital.Repository.Interface;

namespace WPF.Hospital.Repository
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly HospitalDbContext _context;
        public MedicineRepository(HospitalDbContext context)
        {
            _context = context;
        }
        public void Add(Medicine entity)
        {
            _context.Medicine.Add(entity);
        }

        public void Delete(int id)
        {
            var Medicine = _context.Medicine.Find(id);
            if (Medicine != null) 
            {
                _context.Medicine.Remove(Medicine);
            }
        }

        public Medicine Get(int id) => _context.Medicine.Find(id);

        public IEnumerable<Medicine> GetAll() => _context.Medicine.ToList();

        public int Save() => _context.SaveChanges();

        public void Update(Medicine entity)
        {
            _context.Medicine.Update(entity);
        }
    }
}
