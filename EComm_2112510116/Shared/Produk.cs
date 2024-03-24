using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComm_2112510116.Shared
{
    public class Produk
    {
        [Key]
        public int IdProduk { get; set; }

        [Required(ErrorMessage ="Nama Harus Diisi")]
        public string Nama { get; set; } = string.Empty;

        [Required(ErrorMessage = "Deskripsi Harus Diisi")]
        public string Deskripsi { get; set; } = string.Empty;

        [Required(ErrorMessage = "Gambar Harus Diisi")]
        public string GambarUrl { get; set; } = "https://via.placeholder.com/300x300";

        [Required(ErrorMessage = "Harga Harus Diisi")]
        [Range(typeof(decimal), "10000", "1000000", ErrorMessage = "Harga harus diinput antara 10.000 s/d 1.000.000")]
        [Column(TypeName = "decimal(8,2)")]
        public decimal Harga { get; set; }

        [Required(ErrorMessage = "Harga Original Harus Diisi")]
        [Range(typeof(decimal), "10000", "1000000", ErrorMessage = "Harga harus diinput antara 10.000 s/d 1.000.000")]
        [Column(TypeName = "decimal(8,2)")]
        public decimal HargaOriginal { get; set;}

        [Required(ErrorMessage = "Keterangan Publik Harus Dipilih")]
        public bool  IsPublic { get; set; }

        [Required(ErrorMessage = "Keterangan Hapus Harus Dipilih")]
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; } = DateTime.Now;

        [ForeignKey(nameof(IdKategori))]
        public Kategori? Kategori { get; set; }

        [Required(ErrorMessage = "Id Kategori harus diisi   ")]
        public int IdKategori { get; set; }
    }
}
