namespace Bida.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAN")]
    public partial class BAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BAN()
        {
            BIENLAI = new HashSet<BIENLAI>();
        }

        [Key]
        public int MABAN { get; set; }

        public bool? LOAIBAN { get; set; }

        public int? KHUVUC { get; set; }

        public bool? TINHTRANG { get; set; }

        public DateTime? GIOBD { get; set; }

        public DateTime? GIOKT { get; set; }

        public int? MAKH { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BIENLAI> BIENLAI { get; set; }
        public BAN(bool? loaiBan, int? khuVuc, bool? tinhTrang, DateTime? gioBD, DateTime? gioKT)
        {
            LOAIBAN = loaiBan;
            KHUVUC = khuVuc;
            TINHTRANG = tinhTrang;
            GIOBD = gioBD;
            GIOKT = gioKT;
            BIENLAI = new HashSet<BIENLAI>();
        }
    }
}
