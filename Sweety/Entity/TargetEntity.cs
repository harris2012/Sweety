﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweety.Entity
{
    [ExcelTable("简单报表")]
    class TargetEntity : EntityBase
    {
        [ExcelColumn("交易号")]
        public string BusinessNo { get; set; }

        /// <summary>
        /// 单据号
        /// </summary>
        [ExcelColumn("单据号")]
        public string PaperNo { get; set; }

        [ExcelColumn("产品编号")]
        public string ProductNo { get; set; }

        [ExcelColumn("采购数")]
        public int BuyCount { get; set; }

        [ExcelColumn("销售数")]
        public int SellCount { get; set; }
    }
}