namespace Bida.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            BAN = new HashSet<BAN>();
            BIENLAI = new HashSet<BIENLAI>();
        }

        [Key]
        public int MAKH { get; set; }

        [StringLength(100)]
        public string TENKH { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAN> BAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BIENLAI> BIENLAI { get; set; }
        public KHACHHANG(string tenkh, string sdt)
        {
            TENKH = tenkh;
            SDT = sdt;
            BAN = new HashSet<BAN>();
            BIENLAI = new HashSet<BIENLAI>();
        }
    }
}
