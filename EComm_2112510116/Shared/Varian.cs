using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComm_2112510116.Shared
{
    public class Varian
    {
        [Key]
        public int IdVarian { get; set; }

        [Required(ErrorMessage = "Nama Harus Diisi")]
        public string Nama { get; set; } = string.Empty;
        //public List<Produk> Produk { get; set; } = new List<Produk>();

    }
}
