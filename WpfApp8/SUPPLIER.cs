//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp8
{
    using System;
    using System.Collections.Generic;
    
    public partial class SUPPLIER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUPPLIER()
        {
            this.HISTORY_SUPPLIER = new HashSet<HISTORY_SUPPLIER>();
            this.MATERIAL = new HashSet<MATERIAL>();
            this.SHIPMENT = new HashSet<SHIPMENT>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public int INN { get; set; }
        public int ID_TYPE_SUPPLIER { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORY_SUPPLIER> HISTORY_SUPPLIER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MATERIAL> MATERIAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHIPMENT> SHIPMENT { get; set; }
        public virtual TYPE_SUPPLIER TYPE_SUPPLIER { get; set; }
    }
}
