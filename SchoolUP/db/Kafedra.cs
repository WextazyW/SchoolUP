//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolUP.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kafedra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kafedra()
        {
            this.Disciplina = new HashSet<Disciplina>();
            this.Sotrudnik = new HashSet<Sotrudnik>();
            this.Specialnost = new HashSet<Specialnost>();
        }
    
        public string shifr { get; set; }
        public string name { get; set; }
        public string fakultet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Disciplina> Disciplina { get; set; }
        public virtual Fakultet Fakultet1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sotrudnik> Sotrudnik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specialnost> Specialnost { get; set; }
    }
}
