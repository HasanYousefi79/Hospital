using Hospital.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DataLayer.Repository
{
    public interface IPatientsRepository
    {
        List<PatientsListViewModel> GetNamePatient(string filter = "");
        int GetPatientIdByName(string name);
    }
}
