using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class KitapTuru
    {
        [Key] 
        public int Id { get; set; }

        [Required(ErrorMessage = "Kitap Tür Adı boş bırakılamaz!")]  // not null
        [MaxLength(25)]
        [DisplayName("Kitap Türü Adı")]
        public string Ad { get; set; }
    }
}
