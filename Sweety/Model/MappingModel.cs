﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweety.Model
{
    /// <summary>
    /// 商务报表
    /// </summary>
    class MappingModel
    {
        /// <summary>
        /// 数据库编号
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 合同状态
        /// 1 - 正常
        /// 2 - 撤单
        /// 3 - 还利差
        /// </summary>
        public int ContractStatus { get; set; }

        /// <summary>
        /// 组别
        /// </summary>
        public string GroupCategory { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        public string Applicant { get; set; }

        /// <summary>
        /// 货号
        /// </summary>
        public string ProductNo { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        public string ContractNo { get; set; }
    }
}
