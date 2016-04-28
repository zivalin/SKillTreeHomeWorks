using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeworkDay1.Models.ViewModels
{
    /// <summary>
    /// 記帳記錄 
    /// </summary>
    public class MoneyViewModel
    {
        /// <summary>
        /// 序號
        /// </summary>
        [DisplayName("序號")]
        [Required]
        public int SR { get; set; }
        /// <summary>
        /// 異動別
        /// </summary>
        [DisplayName("異動別")]
        [Required(ErrorMessage = "請選擇支出或收入")]
        public string IO { get; set; }
        /// <summary>
        /// 異動日期
        /// </summary>
        [DisplayName("異動日期")]
        [Required]       
        public DateTime CHDT { get; set; }
        /// <summary>
        /// 金額
        /// </summary>
        [DisplayName("金額")] 
        [Required] 
        [Range(0, int.MaxValue, ErrorMessage = "不能輸入負數")]
        public decimal MNY { get; set; }
        /// <summary>
        /// 備註說明
        /// </summary>
        /// <value>The RMK.</value>
        [DisplayName("備註說明")]
        public string RMK { get; set; }
    }
}