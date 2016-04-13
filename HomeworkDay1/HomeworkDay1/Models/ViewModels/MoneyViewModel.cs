using System;
using System.Collections.Generic;
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
        public int SR { get; set; }
        /// <summary>
        /// 異動別
        /// </summary>
        public string IO { get; set; }
        /// <summary>
        /// 異動日期
        /// </summary>
        public DateTime CHDT { get; set; }
        /// <summary>
        /// 金額
        /// </summary>
        public decimal MNY { get; set; }  
    }
}