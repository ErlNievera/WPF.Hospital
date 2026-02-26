using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Hospital.Model;
using WPF.Hospital.Repository.Interface;

namespace WPF.Hospital.Repository
{
    public class PrescriptionRepository : IPrescriptionRepository
    {
        private readonly HospitalDbContext _context;
        public PrescriptionRepository(HospitalDbContext context)
        {
            _context = context;
        }

        public void Add(Prescription entity)
        {
            _context.Prescription.Add(entity);
        }

        public void Delete(int id)
        {
            var Prescription = _context.Prescription.Find(id);
            if (Prescription != null) 
            {
                _context.Prescription.Remove(Prescription);
            }
        }

        public Prescription Get(int id) => _context.Prescription.Find(id);

        public IEnumerable<Prescription> GetAll() => _context.Prescription.ToList();

        public int Save() => _context.SaveChanges();

        public void Update(Prescription entity)
        {
            _context.Prescription.Update(entity);
        }

        IEnumerable<Prescription> IPrescriptionRepository.GetByHistory(int historyId)
        {
            return _context.Prescription.Where(p => p.HistoryId == historyId).ToList();
        }
    }
}
