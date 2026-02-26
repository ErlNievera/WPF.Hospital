using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Hospital.Model;
using WPF.Hospital.Repository;
using WPF.Hospital.Service.Interface;

namespace WPF.Hospital.Service
{
    public class DoctorService : IDoctorService
    {
        private readonly DoctorRepository _doctorRepository;
        public DoctorService(DoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public (bool Ok, string Message) Create(DTO.Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public (bool Ok, string Message) Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DTO.Doctor? Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<DTO.Doctor> GetAll()
        {
            throw new NotImplementedException();
        }

        public (bool Ok, string Message) Update(DTO.Doctor doctor)
        {
            throw new NotImplementedException();
        }
    }
}
