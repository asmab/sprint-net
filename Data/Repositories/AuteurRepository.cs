 

using  Data.Infrastructure;
using  Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data.Models;

namespace  Data.Repositories
{
    public class AuteurRepository : RepositoryBase<auteur>, IAuteurRepository
    {
        public AuteurRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
    public interface IAuteurRepository : IRepository<auteur>
    {

    }
}
