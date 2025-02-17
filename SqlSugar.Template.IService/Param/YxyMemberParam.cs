﻿using DMS.Common.Model.Param;
using System;

namespace SqlSugar.Template.IService.Param
{
    /// <summary>
    /// 添加会员参数
    /// </summary>
    public class AddMemberParam
    {
        /// <summary>
        /// 会员名称
        /// </summary>
        public string MemberName { get; set; }
        /// <summary>
        /// 会员类型
        /// </summary>
        public string MemberType { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string TrueName { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class SearchMemberParam : PageParam
    {
        /// <summary>
        /// 任务消息
        /// </summary>
        public string MemberName { get; set; }

    }
}
