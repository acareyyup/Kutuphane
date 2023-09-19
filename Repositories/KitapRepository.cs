using Entities.Models;
using Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class KitapRepository : Repository<Kitap>, IKitapRepository
    {
        private RepositoryContext _repositoryContext;

        public KitapRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public void Guncelle(Kitap kitap)
        {
            _repositoryContext.Update(kitap);
        }

        public void Kaydet()
        {
            _repositoryContext.SaveChanges();
        }
    }
}
