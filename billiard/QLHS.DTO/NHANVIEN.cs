namespace Bida.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            BIENLAI = new HashSet<BIENLAI>();
        }

        [Key]
        [StringLength(50)]
        public string MANHANVIEN { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNhanVien { get; set; }

        public bool? CALAM { get; set; }

        [StringLength(100)]
        public string PASSNV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BIENLAI> BIENLAI { get; set; }

        public virtual QUANLI QUANLI { get; set; }
    }
}
