//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grades_Students
    {
        public int id { get; set; }
        public Nullable<int> id_Day { get; set; }
        public Nullable<int> id_Student { get; set; }
        public string Algebra { get; set; }
        public string Geometry { get; set; }
        public string Literature { get; set; }
        public string Physical_education { get; set; }
        public string Russian_language { get; set; }
        public string Work_ { get; set; }
    
        public virtual Schedule Schedule { get; set; }
        public virtual Students Students { get; set; }
    }
}
