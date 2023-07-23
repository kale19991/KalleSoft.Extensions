using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalleSoft.Extensions.Strings
{
    public static class StringExtension
    {
        #region String
        public static string? ToMaskTelefone(this string strNumero, bool pontuacao = false)
        {
            try
            {
                strNumero = strNumero.Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty);
                if (pontuacao)
                {
                    // por omissão tem 10 ou menos dígitos
                    string strMascara = "{0:(00) 0000-0000}";
                    // converter o texto em número
                    long lngNumero = System.Convert.ToInt64(strNumero);
                    return string.Format(strMascara, lngNumero);
                }
                return strNumero;

            }
            catch (Exception)
            {

                return null;
            }
        }
        public static string? ToMaskCelular(this string strNumero, bool pontuacao = false)
        {
            try
            {
                if (string.IsNullOrEmpty(strNumero)) return null;

                strNumero = strNumero
                .Replace("(", string.Empty)
                .Replace(")", string.Empty)
                .Replace("-", string.Empty);
                if (pontuacao)
                {
                    // por omissão tem 10 ou menos dígitos
                    string strMascara = "{0:(00) 00000-0000}";
                    // converter o texto em número
                    long lngNumero = System.Convert.ToInt64(strNumero);
                    return string.Format(strMascara, lngNumero);
                }
                return strNumero;
            }
            catch (Exception)
            {

                return null;
            }

        }
        public static string? ToMaskCep(this string strNumero, bool pontuacao = false)
        {
            try
            {
                if (string.IsNullOrEmpty(strNumero) || (strNumero == "00000-000") || (strNumero == "00000000"))
                    return null;

                strNumero = strNumero
                .Replace("(", string.Empty)
                .Replace(")", string.Empty)
                .Replace("-", string.Empty)
                .Replace(".", string.Empty);
                // por omissão tem 10 ou menos dígitos 08253-000

                if (pontuacao)
                {
                    string strMascara = "{0:00000-000}";
                    // converter o texto em número
                    long lngNumero = System.Convert.ToInt64(strNumero);
                    return string.Format(strMascara, lngNumero);
                }
                return strNumero;


            }
            catch (Exception)
            {

                return null;
            }

        }
        #endregion
    }
}