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
    
    public partial class Sotrudnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sotrudnik()
        {
            this.Exam = new HashSet<Exam>();
        }
    
        public int tab_nomer { get; set; }
        public string shifr { get; set; }
        public string Familiya { get; set; }
        public string Doljnost { get; set; }
        public Nullable<int> Zarplata { get; set; }
        public Nullable<int> Shef { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exam> Exam { get; set; }
        public virtual Ingener Ingener { get; set; }
        public virtual Kafedra Kafedra { get; set; }
        public virtual Prepodavatel Prepodavatel { get; set; }
        public virtual Zav_kafedra Zav_kafedra { get; set; }
    }
}
