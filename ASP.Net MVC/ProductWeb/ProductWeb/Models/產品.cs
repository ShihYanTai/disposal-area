//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class 產品
    {
        [Required(ErrorMessage = "編號必填")]
        public string 編號 { get; set; }
        [Required(ErrorMessage = "品名必填")]
        public string 品名 { get; set; }
        [Required(ErrorMessage = "數量必填")]
        public Nullable<int> 單價 { get; set; }
        public Nullable<int> 數量 { get; set; }
        public string 圖示 { get; set; }
    }
}
