//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DressUp_Scl_Data.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseList
    {
        public System.Guid OrderNum { get; set; }
        public string OrderType { get; set; }
        public Nullable<System.Guid> GoodsId { get; set; }
        public string GoodsName { get; set; }
        public int StorageNum { get; set; }
        public string OrderStatus { get; set; }
        public System.DateTime OrderTime { get; set; }
    }
}