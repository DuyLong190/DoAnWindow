namespace Bida.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BIENLAI")]
    public partial class BIENLAI
    {
        [Key]
        public int MABIENLAI { get; set; }

        [Required]
        [StringLength(50)]
        public string MANHANVIEN { get; set; }

        public int MABAN { get; set; }

        public int? MAKH { get; set; }

        [StringLength(50)]
        public string ThoiGian { get; set; }

        [StringLength(10)]
        public string TONGTIEN { get; set; }

        public DateTime? GioBD { get; set; }

        public DateTime? GioKT { get; set; }

        public virtual BAN BAN { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
        public BIENLAI(NHANVIEN nhanvien, BAN ban, KHACHHANG khachhang, DateTime? gioBD, DateTime? gioKT, string thoiGian, string tongTien)
        {
            NHANVIEN = nhanvien;
            BAN = ban;
            KHACHHANG = khachhang;
            GioBD = gioBD;
            GioKT = gioKT;
            ThoiGian = thoiGian;
            TONGTIEN = tongTien;
        }
    }
}
