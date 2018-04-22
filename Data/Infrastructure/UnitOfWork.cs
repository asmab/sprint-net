using Data;
using Data.Interfaces;
using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private mediaContext dataContext;
        protected mediaContext DataContext
        {
            get
            {
                return dataContext = dbFactory.DataContext;
            }
        }

        IDatabaseFactory dbFactory;
        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public void Commit()
        {
            DataContext.SaveChanges();
        }


        private IMediaRepository mediaRepository;
     
        public IMediaRepository MediaRepository
        {
            get { return mediaRepository = new MediaRepository(dbFactory); }
        }

        private IAuteurRepository auteurRepository;
        public IAuteurRepository AuteurRepository
        {
            get { return auteurRepository = new AuteurRepository(dbFactory); ; }
        }

         

        
        public void Dispose()
        {
            DataContext.Dispose();
        }
        
    }
}
