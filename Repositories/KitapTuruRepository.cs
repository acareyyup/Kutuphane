using Entities.Models;
using Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class KitapTuruRepository : Repository<KitapTuru>, IKitapTuruRepository
    {
        private RepositoryContext _repositoryContext;
        public KitapTuruRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public void Guncelle(KitapTuru kitapTuru)
        {
            _repositoryContext.Update(kitapTuru);
        }

        public void Kaydet()
        {
            _repositoryContext.SaveChanges();
        }
    }
}
