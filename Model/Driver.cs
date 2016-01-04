using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public class Driver
    {
        /// <summary>
        /// 主键值
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 用户中文名
        /// </summary>
        public string User_ChineseName { get; set; }

        /// <summary>
        /// 用户英文名
        /// </summary>
        public string User_EnglishName { get; set; }

        /// <summary>
        /// 部门中文名
        /// </summary>
        public string Department_ChineseName { get; set; }



        /// <summary>
        /// 部门英文名
        /// </summary>
        public string Department_EnglishName { get; set; }

        /// <summary>
        /// 职务
        /// </summary>
        public string Job { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        public string Birthdy { get; set; }


        /// <summary>
        /// 身份证件类型
        /// </summary>
        public string Identification_Type { get; set; }

        /// <summary>
        /// 身份证件号码
        /// </summary>
        public string Identification_Number { get; set; }

        /// <summary>
        /// 工作单位
        /// </summary>
        public string Employer { get; set; }



        /// <summary>
        /// 联系方式
        /// </summary>
        public string Telephone { get; set; }
    }
}
