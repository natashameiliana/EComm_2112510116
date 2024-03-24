using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EComm_2112510116.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    IdKategori = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.IdKategori);
                });

            migrationBuilder.CreateTable(
                name: "Varian",
                columns: table => new
                {
                    IdVarian = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Varian", x => x.IdVarian);
                });

            migrationBuilder.CreateTable(
                name: "Produk",
                columns: table => new
                {
                    IdProduk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deskripsi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GambarUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Harga = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    HargaOriginal = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdKategori = table.Column<int>(type: "int", nullable: false),
                    VarianIdVarian = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produk", x => x.IdProduk);
                    table.ForeignKey(
                        name: "FK_Produk_Kategori_IdKategori",
                        column: x => x.IdKategori,
                        principalTable: "Kategori",
                        principalColumn: "IdKategori",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produk_Varian_VarianIdVarian",
                        column: x => x.VarianIdVarian,
                        principalTable: "Varian",
                        principalColumn: "IdVarian");
                });

            migrationBuilder.InsertData(
                table: "Kategori",
                columns: new[] { "IdKategori", "Nama" },
                values: new object[,]
                {
                    { 1, "Crime" },
                    { 2, "Thriller" },
                    { 3, "Drama" }
                });

            migrationBuilder.InsertData(
                table: "Varian",
                columns: new[] { "IdVarian", "Nama" },
                values: new object[,]
                {
                    { 1, "Soft Cover" },
                    { 2, "Hard Cover" },
                    { 3, "Digital" }
                });

            migrationBuilder.InsertData(
                table: "Produk",
                columns: new[] { "IdProduk", "DateCreated", "DateUpdated", "Deskripsi", "GambarUrl", "Harga", "HargaOriginal", "IdKategori", "IsDeleted", "IsPublic", "Nama", "VarianIdVarian" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Misteri Tujuh Lonceng adalah sebuah novel yang bercerita tentang pembunuhan seorang Pegawai Departemen Luar Negeri Inggris di sebuah pemondokan, yaitu pemondokan Chimney. Setelah itu Terjadi juga pembunuhan terhadap seorang pria yang tidak lain adalah teman orang yang terbunuh di pemondokan Chimney.", "https://upload.wikimedia.org/wikipedia/id/4/4c/The_Seven_Dials_Mystery_First_Edition_Cover_1929.jpg", 99.999m, 100.000m, 1, false, true, "Misteri Tujuh Lonceng", null },
                    { 2, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dalam buku ini, Hercule Poirot menerima telegram dari miliarder bernama Paul Renauld, yang memintanya datangke vilanya di Prancis. Saat Poirot tiba, Renauld telah meninggal; tubuhnya ditusuk dan terbaring disebuah lapangan golf.Istrinya mengklaim bahwa ia telah diculik oleh dua orang Chili. Ternyata kemudian diketahui bahwa Renauld telah merencanakanuntuk memalsukan kematiannya sendiri, tetapi (tentu saja) kemudian terjadi peristiwa-peristiwa yang merusak rencananya.", "https://upload.wikimedia.org/wikipedia/id/f/f0/Lapangangolfmaut.jpg", 89.999m, 100.000m, 1, false, true, "Lapangan Golf Maut", null },
                    { 3, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Empat Besar atau The Big Four adalah novel detektif fiksi karya Agatha Christie dan pertama kali diterbitkan di Britania Raya oleh William Collins & Sons pada tanggal 27 Januari 1927 dan di Amerika Serikat oleh Dodd, Mead and Company pada tahun yang sama.Novel ini menampilkan karakter Hercule Poirot, Arthur Hastings dan Chief Inspector Japp.", "https://upload.wikimedia.org/wikipedia/id/4/49/The_Big_Four_First_Edition_Cover_1927.jpg", 59.999m, 100.000m, 1, false, true, "Empat Besar", null },
                    { 4, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Penelusuran Benang Merah (judul asli dalam bahasa Inggris: A Study in Scarlet)adalah novel fiksi detektif karya Sir Arthur Conan Doyle yang memperkenalkan tokoh detektif konsultan rekaannya, Sherlock Holmes,serta sahabat sekaligus penulis kisah petualangannya, dr. Watson, yang kelak akanmenjadi dua tokoh terkenal dalam dunia sastra.\r\n", "https://upload.wikimedia.org/wikipedia/id/5/56/Penelusuran_Benang_Merah.jpg", 129.999m, 300.000m, 2, false, true, "Penelusuran Benang Merah", null },
                    { 5, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Empat Pemburu Harta (judul asli dalam bahasa Inggris:The Sign of Four) adalah novel kedua karya Sir Arthur Conan Doyle yang menampilkan Sherlock Holmes, terbit pertama kali pada tahun 1890 di Lippincott's Monthly Magazine.", "https://upload.wikimedia.org/wikipedia/id/9/96/Empat_Pemburu_Harta.jpg", 149.999m, 500.000m, 2, false, true, "Empat Pemburu Harta", null },
                    { 6, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lembah Ketakutan atau The Valley of Fear adalah novel Sherlock Holmes keempat dan terakhir karya Sir Arthur Conan Doyle. Karya tersebut berdasarkan pada Molly Maguires dan agen Pinkerton James McParland. Cerita tersebut mula-mula trbit dalam Strand Magazine antara September 1914 dan Mei 1915. Edisi buku pertamanya diberi hak cipta pada 1914, dan karya tersebut mulamula diterbitkan oleh George H. Doran Company di New York pada 27 Februari 1915, dan diilustrasikan oleh Arthur I. Keller..", "https://upload.wikimedia.org/wikipedia/commons/8/84/Valley_of_fear.jpg", 139.999m, 300.000m, 2, false, true, "Lembah Ketakutan", null },
                    { 7, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laskar Pelangi adalah novel pertama karya Andrea Hirata yang diterbitkan oleh Bentang Pustaka pada tahun 2005. Novel ini bercerita tentang kehidupan 10 anak dari keluarga miskin yang bersekolah (SD dan SMP) disebuah sekolah Muhammadiyah di Belitung yang penuh dengan keterbatasan..", "https://upload.wikimedia.org/wikipedia/id/8/8e/Laskar_pelangi_sampul.jpg", 99.999m, 150.000m, 3, false, true, "Laskar Pelangi", null },
                    { 8, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sang Pemimpi Baru adalah novel kedua dalam tetralogi Laskar Pelangi karya Andrea Hirata yang diterbitkan oleh Bentang Pustaka pada Juli 2006. Dalam novel ini, Andrea mengeksplorasi hubungan persahabatannya dengan dua anak yatim piatu, Arai Ichsanul Mahidin dan Jimbron, serta kekuatan mimpi yang dapat membawa Andrea dan Arai melanjutkan studi ke Sorbonne, Paris, Prancis.", "https://upload.wikimedia.org/wikipedia/id/8/89/Sang_Pemimpi_sampul.jpg", 99.999m, 150.000m, 3, false, true, "Sang Pemimpin", null },
                    { 9, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edensor adalah buku ketiga dari Tetralogi Laskar Pelangi karya Andrea Hirata yang diterbitkan oleh Bentang Pustaka pada bulan Mei tahun 2007. Buku berikutnya dan yang terakhir adalah Maryamah Karpov. Edensor masuk nominasi penghargaan nasional sastra KLA (Khatulistiwa Literary Award) tahun 2007.", "https://upload.wikimedia.org/wikipedia/id/e/ec/Edensor_sampul.jpg", 99.999m, 150.000m, 3, false, true, "Edensor", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produk_IdKategori",
                table: "Produk",
                column: "IdKategori");

            migrationBuilder.CreateIndex(
                name: "IX_Produk_VarianIdVarian",
                table: "Produk",
                column: "VarianIdVarian");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produk");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "Varian");
        }
    }
}
