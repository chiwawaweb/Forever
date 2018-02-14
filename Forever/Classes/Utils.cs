using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Net.Mail;
using System.ComponentModel.DataAnnotations;

namespace Forever.Classes
{
    public class Utils
    {
        public string RemoveDiacritics(String s)
        {
            String normalizedString = s.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < normalizedString.Length; i++)
            {
                Char c = normalizedString[i];
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
            }
            return stringBuilder.ToString();
        }

        public string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                return "";
            }
        }

        /// <summary>
        /// Vérifie la validité d'une adresse email.
        /// </summary>
        /// <param name="email">Adresse email à vérifier</param>
        /// <returns></returns>
        public bool IsEmailValid(string email)
        {
            try
            {
                if (email != "")
                {
                    if (new EmailAddressAttribute().IsValid(email))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            catch (FormatException)
            {
                return false;
            }
        }

        /// <summary>
        /// N'accepte que la saisie de chiffres, sans aucune décimale.
        /// </summary>
        /// <param name="e"></param>
        public void ChiffreOnly(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        /// <summary>
        /// Lecture d'un paramètre de configuration
        /// </summary>
        /// <param name="key"></param>
    }
}
