using System.ComponentModel.DataAnnotations;

namespace ValidationDemo
{
    public class OrgRegInfo
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [StringLength(50, MinimumLength = 3, ErrorMessage = "用户名长度为3-50个字符")]
        [Required(ErrorMessage = "请填写用户名")]
        public string? name { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [StringLength(100, ErrorMessage = "邮箱最大支持100个字符，请更换邮箱")]
        [EmailAddress(ErrorMessage = "邮箱格式不正常")]
        [Required(ErrorMessage = "请填写公司邮箱")]
        public string? email { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [StringLength(50, MinimumLength = 8, ErrorMessage = "密码长度为8-50个字符")]
        [Required(ErrorMessage = "请填写密码")]
        public string? pwd { get; set; }

        /// <summary>
        /// 信用代码
        /// </summary>
        [Required(ErrorMessage = "请填写统一社会信用代码")]
        public string? orgid { get; set; }
        /// <summary>
        /// 企业名称
        /// </summary>
        [StringLength(80, MinimumLength = 2, ErrorMessage = "企业名称2-80个字符")]
        [Required(ErrorMessage = "请填写工商注册的企业名称")]
        public string? orgname { get; set; }
        /// <summary>
        /// 联系人信息
        /// </summary>
        [StringLength(20, MinimumLength = 2, ErrorMessage = "企业联系人2-20个字符")]
        [Required(ErrorMessage = "请填写企业联系人")]
        public string? orguser { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [Phone(ErrorMessage = "联系人电话格式有误")]
        [Required(ErrorMessage = "请填写联系人电话")]
        public string? orgphone { get; set; }
    }
}
