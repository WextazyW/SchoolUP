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
    
    public partial class Zav_kafedra
    {
        public int tab_nomer { get; set; }
        public Nullable<int> staj { get; set; }
    
        public virtual Sotrudnik Sotrudnik { get; set; }
    }
}
