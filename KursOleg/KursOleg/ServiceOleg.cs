//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KursOleg
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServiceOleg
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Id { get; set; }
        public string Photo { get; set; }
        public Nullable<int> NaryadId { get; set; }
    
        public virtual NaryadOleg NaryadOleg { get; set; }
    }
}
