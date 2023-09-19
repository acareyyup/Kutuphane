using Entities.Models;
using Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class KiralamaRepository : Repository<Kiralama>, IKiralamaRepository
    {
        private RepositoryContext _repositoryContext;

        public KiralamaRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public void Guncelle(Kiralama kiralama)
        {
            _repositoryContext.Update(kiralama);
        }

        public void Kaydet()
        {
            _repositoryContext.SaveChanges();
        }
    }
}
