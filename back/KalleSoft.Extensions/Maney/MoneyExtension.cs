using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalleSoft.Extensions.Maney
{
    public static class MoneyExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static int ToCents(this decimal amount)
        {
            if (amount <= 0)
                return 0;
            
            var text = amount.ToString("N2")
                .Replace(",", string.Empty)
                .Replace(".", string.Empty);
            if (string.IsNullOrWhiteSpace(text))
                return 0;

            int.TryParse(text, out var result);
            return result;
        }
    }
}