using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCHOMEWORK.Models
{

    [MetadataType(typeof(vw_CustomerContactorBankCountMetaData))]
    public partial class vw_CustomerContactorBankCount
    {
     
    }

    public partial class vw_CustomerContactorBankCountMetaData
    {
        [DisplayName("客戶名稱")]
        public string CustomerName { get; set; }

        [DisplayName("帳戶數目")]
        public Nullable<int> AccountCount { get; set; }

        [DisplayName("聯絡人數目")]
        public Nullable<int> ContactCount { get; set; }
    }
}