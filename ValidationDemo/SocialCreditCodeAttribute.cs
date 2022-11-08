using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ValidationDemo
{
    public class SocialCreditCodeAttribute : Attribute, IModelValidator
    {
        // 自定义一个异常信息属性
        public string ErrorMessage { get; set; }
        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            var code = context.Model as string;

            // 长度不为18
            if (code == null || code.Length != 18)
            {
                // 抛出异常信息集合
                return new List<ModelValidationResult>
                {
                    new ModelValidationResult(string.Empty,ErrorMessage)
                };
            }

            code = code.ToUpper();
            int[] factor = { 1, 3, 9, 27, 19, 26, 16, 17, 20, 29, 25, 13, 8, 24, 10, 30, 28 };
            string str = "0123456789ABCDEFGHJKLMNPQRTUWXY";
            int total = factor.Select((p, i) => p * str.IndexOf(code[i])).Sum();
            int index = total % 31 == 0 ? 0 : (31 - total % 31);
            if (str[index] != code.Last())
            {
                // 抛出异常信息集合
                return new List<ModelValidationResult>
                {
                    new ModelValidationResult(string.Empty,ErrorMessage)
                };
            }
            // 如果没有异常，就抛出一个空集合
            return Enumerable.Empty<ModelValidationResult>();
        }
    }
}
