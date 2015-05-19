using EF_MVC_Repository_UOW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_MVC_Repository_UOW.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Project> ProjectRepository { get; }
        void Save();
    }

    public partial class UnitOfWork : IUnitOfWork
    {
        private IRepository<Project> _projectRepository;
        private Context _context;

        //Add any new repository here 

        public IRepository<Project> ProjectRepository
        {
            get {

                if (_projectRepository==null)
                    _projectRepository = new Repository<Project>(_context);

                return _projectRepository; }
        }

        public UnitOfWork()
        {
            _context=new Context("mpDBConnection");
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
}
}
