namespace EComm_2112510116.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        public DbSet<Produk> Produk { get; set; }
        public DbSet<Varian> Varian { get; set; }
        public DbSet<Kategori> Kategori { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produk>().HasData(

            new Produk
                 {
                     IdProduk = 1,
                     IdKategori = 1,
                     Nama = "Misteri Tujuh Lonceng",
                     Deskripsi = "Misteri Tujuh Lonceng adalah sebuah " +
                "novel yang bercerita tentang pembunuhan seorang Pegawai Departemen Luar " +
                "Negeri Inggris di sebuah pemondokan, yaitu pemondokan Chimney. Setelah itu " +
                "Terjadi juga pembunuhan terhadap seorang pria yang tidak lain adalah teman " +
                "orang yang terbunuh di pemondokan Chimney.",
                     GambarUrl = "https://upload.wikimedia.org/wikipedia/id/4/4c/The_Seven_Dials_Mystery_First_Edition_Cover_1929.jpg",
                     Harga = 99.999m,
                     HargaOriginal = 100.000m,
                     DateCreated = new DateTime(2024, 3, 10),
                     DateUpdated = new DateTime(2024, 3, 10),
                     IsDeleted = false,
                     IsPublic = true
                 },

            new Produk
            {
                IdProduk = 2,
                IdKategori = 1,
                Nama = "Lapangan Golf Maut",
                Deskripsi = "Dalam buku ini, Hercule Poirot menerima telegram dari miliarder bernama Paul Renauld, yang memintanya datang" +
                "ke vilanya di Prancis. Saat Poirot tiba, Renauld telah meninggal; tubuhnya ditusuk dan terbaring disebuah lapangan golf." +
                "Istrinya mengklaim bahwa ia telah diculik oleh dua orang Chili. Ternyata kemudian diketahui bahwa Renauld telah merencanakan" +
                "untuk memalsukan kematiannya sendiri, tetapi (tentu saja) kemudian terjadi peristiwa-peristiwa yang merusak rencananya.",
                GambarUrl = "https://upload.wikimedia.org/wikipedia/id/f/f0/Lapangangolfmaut.jpg",
                Harga = 89.999m,
                HargaOriginal = 100.000m,
                DateCreated = new DateTime(2024, 3, 10),
                DateUpdated = new DateTime(2024, 3, 10),
                IsDeleted = false,
                IsPublic = true
            },

            new Produk
            {
                IdProduk = 3,
                IdKategori = 1,
                Nama = "Empat Besar",
                Deskripsi = "Empat Besar atau The Big Four adalah novel detektif " +
                "fiksi karya Agatha Christie dan pertama kali diterbitkan di Britania Raya oleh " +
                "William Collins & Sons pada tanggal 27 Januari 1927 dan di Amerika Serikat oleh " +
                "Dodd, Mead and Company pada tahun yang sama.Novel ini menampilkan karakter " +
                "Hercule Poirot, Arthur Hastings dan Chief Inspector Japp.",
                GambarUrl = "https://upload.wikimedia.org/wikipedia/id/4/49/The_Big_Four_First_Edition_Cover_1927.jpg",
                Harga = 59.999m,
                HargaOriginal = 100.000m,
                DateCreated = new DateTime(2024, 3, 10),
                DateUpdated = new DateTime(2024, 3, 10),
                IsDeleted = false,
                IsPublic = true
            },

            new Produk
            {
                IdProduk = 4,
                IdKategori = 2,
                Nama = "Penelusuran Benang Merah",
                Deskripsi = "Penelusuran Benang Merah (judul asli dalam bahasa Inggris: A Study in Scarlet)" +
                "adalah novel fiksi detektif karya Sir Arthur Conan Doyle " +
                "yang memperkenalkan tokoh detektif konsultan rekaannya, Sherlock Holmes," +
                "serta sahabat sekaligus penulis kisah petualangannya, dr. Watson, yang kelak akan" +
                "menjadi dua tokoh terkenal dalam dunia sastra.\r\n",
                GambarUrl = "https://upload.wikimedia.org/wikipedia/id/5/56/Penelusuran_Benang_Merah.jpg",
                Harga = 129.999m,
                HargaOriginal = 300.000m,
                DateCreated = new DateTime(2024, 3, 10),
                DateUpdated = new DateTime(2024, 3, 10),
                IsDeleted = false,
                IsPublic = true
            },

            new Produk
            {
                IdProduk = 5,
                IdKategori = 2,
                Nama = "Empat Pemburu Harta",
                Deskripsi = "Empat Pemburu Harta (judul asli dalam bahasa Inggris:" +
                "The Sign of Four) adalah novel kedua karya Sir Arthur Conan Doyle yang " +
                "menampilkan Sherlock Holmes, terbit pertama kali pada tahun 1890 di Lippincott's " +
                "Monthly Magazine.",
                GambarUrl = "https://upload.wikimedia.org/wikipedia/id/9/96/Empat_Pemburu_Harta.jpg",
                Harga = 149.999m,
                HargaOriginal = 500.000m,
                DateCreated = new DateTime(2024, 3, 10),
                DateUpdated = new DateTime(2024, 3, 10),
                IsDeleted = false,
                IsPublic = true
            },

            new Produk
            {
                IdProduk = 6,
                IdKategori = 2,
                Nama = "Lembah Ketakutan",
                Deskripsi = "Lembah Ketakutan atau The Valley of Fear adalah novel " +
                "Sherlock Holmes keempat dan terakhir karya Sir Arthur Conan Doyle. Karya tersebut " +
                "berdasarkan pada Molly Maguires dan agen Pinkerton James McParland. Cerita " +
                "tersebut mula-mula trbit dalam Strand Magazine antara September 1914 dan Mei " +
                "1915. Edisi buku pertamanya diberi hak cipta pada 1914, dan karya tersebut mula" +
                "mula diterbitkan oleh George H. Doran Company di New York pada 27 Februari 1915, " +
                "dan diilustrasikan oleh Arthur I. Keller..",
                GambarUrl = "https://upload.wikimedia.org/wikipedia/commons/8/84/Valley_of_fear.jpg",
                Harga = 139.999m,
                HargaOriginal = 300.000m,
                DateCreated = new DateTime(2024, 3, 10),
                DateUpdated = new DateTime(2024, 3, 10),
                IsDeleted = false,
                IsPublic = true
            },

            new Produk
            {
                IdProduk = 7,
                IdKategori = 3,
                Nama = "Laskar Pelangi",
                Deskripsi = "Laskar Pelangi adalah novel pertama karya Andrea " +
                "Hirata yang diterbitkan oleh Bentang Pustaka pada tahun 2005. Novel ini bercerita " +
                "tentang kehidupan 10 anak dari keluarga miskin yang bersekolah (SD dan SMP) di" +
                "sebuah sekolah Muhammadiyah di Belitung yang penuh dengan keterbatasan..",
                GambarUrl = "https://upload.wikimedia.org/wikipedia/id/8/8e/Laskar_pelangi_sampul.jpg",
                Harga = 99.999m,
                HargaOriginal = 150.000m,
                DateCreated = new DateTime(2024, 3, 10),
                DateUpdated = new DateTime(2024, 3, 10),
                IsDeleted = false,
                IsPublic = true
            },

            new Produk
            {
                IdProduk = 8,
                IdKategori = 3,
                Nama = "Sang Pemimpin",
                Deskripsi = "Sang Pemimpi Baru adalah novel kedua dalam tetralogi " +
                "Laskar Pelangi karya Andrea Hirata yang diterbitkan oleh Bentang Pustaka pada " +
                "Juli 2006. Dalam novel ini, Andrea mengeksplorasi hubungan persahabatannya dengan " +
                "dua anak yatim piatu, Arai Ichsanul Mahidin dan Jimbron, serta kekuatan mimpi " +
                "yang dapat membawa Andrea dan Arai melanjutkan studi ke Sorbonne, Paris, " +
                "Prancis.",
                GambarUrl = "https://upload.wikimedia.org/wikipedia/id/8/89/Sang_Pemimpi_sampul.jpg",
                Harga = 99.999m,
                HargaOriginal = 150.000m,
                DateCreated = new DateTime(2024, 3, 10),
                DateUpdated = new DateTime(2024, 3, 10),
                IsDeleted = false,
                IsPublic = true
            },

            new Produk
            {
                IdProduk = 9,
                IdKategori = 3,
                Nama = "Edensor",
                Deskripsi = "Edensor adalah buku ketiga dari Tetralogi Laskar " +
                "Pelangi karya Andrea Hirata yang diterbitkan oleh Bentang Pustaka pada bulan Mei " +
                "tahun 2007. Buku berikutnya dan yang terakhir adalah Maryamah Karpov. Edensor " +
                "masuk nominasi penghargaan nasional sastra KLA (Khatulistiwa Literary Award) " +
                "tahun 2007.",
                GambarUrl = "https://upload.wikimedia.org/wikipedia/id/e/ec/Edensor_sampul.jpg",
                Harga = 99.999m,
                HargaOriginal = 150.000m,
                DateCreated = new DateTime(2024, 3, 10),
                DateUpdated = new DateTime(2024, 3, 10),
                IsDeleted = false,
                IsPublic = true
            }

            );

            modelBuilder.Entity<Kategori>().HasData(

            new Kategori
            {
                IdKategori = 1,
                Nama = "Crime",
            },

            new Kategori
            {
                IdKategori = 2,
                Nama = "Thriller",
            },

            new Kategori
            {
                IdKategori = 3,
                Nama = "Drama",
            }

                );

            modelBuilder.Entity<Varian>().HasData(

            new Varian
            {
                IdVarian = 1,
                Nama = "Soft Cover",
            },

            new Varian
            {
                IdVarian = 2,
                Nama = "Hard Cover",
            },

            new Varian
            {
                IdVarian = 3,
                Nama = "Digital",
            }

                );



        }

    }
}
