using Data.Infrastructure;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public class AuteurService:IAuteurService
    {
       static public DatabaseFactory dbFactory = new DatabaseFactory();
       UnitOfWork utwk = new UnitOfWork(dbFactory);
        public void AddAuteur(auteur a)
        {
            utwk.AuteurRepository.Add(a);
            utwk.Commit();
        }

        public List<auteur> getAllAuteurs()
        {
            return utwk.AuteurRepository.GetAll().ToList();
        }
    }

   public interface IAuteurService
   {
       void AddAuteur(auteur a);
       List<auteur> getAllAuteurs();
   }
}
