//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FHYL.Lottery.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CashRecord
    {
        public int id { get; set; }
        public string CashBy { get; set; }
        public System.DateTime CashDate { get; set; }
        public decimal CashMoney { get; set; }
        public string Remark { get; set; }
        public int UserId { get; set; }
    
        public virtual CashRecord CashRecord1 { get; set; }
        public virtual CashRecord CashRecord2 { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
