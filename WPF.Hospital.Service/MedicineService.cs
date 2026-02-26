using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Hospital.Model;
using WPF.Hospital.Repository;
using WPF.Hospital.Repository.Interface;
using WPF.Hospital.Service.Interface;

namespace WPF.Hospital.Service
{
    public class MedicineService : IMedicineService
    {
        private readonly MedicineRepository _medicineRepository;
        private readonly PrescriptionRepository _prescriptionRepository;
        public MedicineService(PrescriptionRepository prescriptionRepository ,MedicineRepository medicineRepository)
        {
            _medicineRepository = medicineRepository;
            _prescriptionRepository = prescriptionRepository;
        }

        public (bool Ok, string Message) Create(DTO.Medicine medicine)
        {
            throw new NotImplementedException();
        }

        public (bool Ok, string Message) Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DTO.Medicine? Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<DTO.Medicine> GetAll()
        {
            throw new NotImplementedException();
        }

        public (bool Ok, string Message) Update(DTO.Medicine medicine)
        {
            throw new NotImplementedException();
        }
    }
}
