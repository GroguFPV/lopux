//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lopux.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Nullable<int> Article { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string image_path { get; set; }
        public byte[] image_bin { get; set; }
        public Nullable<int> product_type_id { get; set; }
        public Nullable<int> human_count { get; set; }
        public Nullable<int> workshop { get; set; }
    
        public virtual ProductType ProductType { get; set; }
    }
}
