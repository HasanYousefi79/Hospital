using Hospital.DataLayer.Repository;
using Hospital.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        Hospital_DBEntities db = new Hospital_DBEntities();

        private IPatientsRepository _patientsRepository;
        public IPatientsRepository PatientsRepository
        {
            get
            {
                if(_patientsRepository==null)
                {
                    _patientsRepository = new PatientsRepository(db);
                }
                return _patientsRepository;
            }
        }
        private GenericRepository<Patient> _PgenericRepository;
        public GenericRepository<Patient> PGenericRepository
        {
            get
            {
                if (_PgenericRepository == null)
                {
                    _PgenericRepository = new GenericRepository<Patient>(db);
                }
                return _PgenericRepository;
            }
        }

        private GenericRepository<Doctor> _DgenericRepository;
        public GenericRepository<Doctor> DGetGenericRepository
        {
            get
            {
                if (_DgenericRepository == null)
                {
                    _DgenericRepository = new GenericRepository<Doctor>(db);
                }
                return _DgenericRepository;
            }
        }

        private GenericRepository<Staff> _SgenericRepository;
        public GenericRepository<Staff> SGenericRepository
        {
            get
            {
                if (_SgenericRepository == null)
                {
                    _SgenericRepository = new GenericRepository<Staff>(db);
                }
                return _SgenericRepository;
            }
        }

        private GenericRepository<Manager> _MgenericRepository;
        public GenericRepository<Manager> MGenericRepository
        {
            get
            {
                if (_MgenericRepository == null)
                {
                    _MgenericRepository = new GenericRepository<Manager>(db);
                }
                return _MgenericRepository;
            }
        }

        private GenericRepository<LogIn> _loginRepository;
        public GenericRepository<LogIn> LoginRepository
        {
            get
            {
                if (_loginRepository == null)
                {
                    _loginRepository = new GenericRepository<LogIn>(db);
                }
                return _loginRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
