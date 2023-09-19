﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contract
{
    public interface IKitapTuruRepository : IRepository<KitapTuru>
    {
        void Guncelle(KitapTuru kitapTuru);
        void Kaydet();
    }
}
