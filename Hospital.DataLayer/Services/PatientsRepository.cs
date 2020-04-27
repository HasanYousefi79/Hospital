using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.DataLayer.Repository;
using Hospital.ViewModel;

namespace Hospital.DataLayer.Services
{
    public class PatientsRepository : IPatientsRepository
    {
        private Hospital_DBEntities db;
        public PatientsRepository(Hospital_DBEntities context)
        {
            db = context;
        }

        public List<PatientsListViewModel> GetNamePatient(string filter = "")
        {
            if (filter == "")
            {
                return db.Patients.Select(p => new PatientsListViewModel()
                {
                    PatientID = p.PatientID,
                    PatientName = p.PatientName
                }).ToList();
            }
            return db.Patients.Where(p => p.PatientName.Contains(filter)).Select(p => new PatientsListViewModel()
            {
                PatientID = p.PatientID,
                PatientName = p.PatientName
            }).ToList();
        }

        public int GetPatientIdByName(string name)
        {
            return db.Patients.First(p => p.PatientName == name).PatientID;
        }
    }
}
