using System;
using System.Collections.Generic;
using System.Text;

namespace FhConverter.Model
{
    public class Phone
    {
        public string Code { get; set; }
        public string Number { get; set; }

        public Phone(string phone)
        {
            phone = ReplaceBadSymbols(phone);
            
            switch (phone.Length)
            {
                case 10:
                    Code = phone.Substring(0, 3);
                    Number = phone.Substring(3, 7);
                    break;
                case 11:
                    if (phone[0] == '7' || phone[0] == '8')
                    {
                        Code = phone.Substring(1, 3);
                        Number = phone.Substring(4, 7);
                        break;
                    }
                    else 
                        throw new InvalidCastException(string.Format("{0}, кривой номер, длина {1}", phone, phone.Length));
                default:
                    throw new InvalidCastException(string.Format("{0}, кривой номер, длина {1}", phone, phone.Length));                    
            }
        }

        public string ReplaceBadSymbols(string phone)
        {
            string[] replaceSymbols = { "+7", "+", "-", " ", "_", "(", ")" };

            var sb = new StringBuilder(phone);
            foreach(var symbol in replaceSymbols)
                sb.Replace(symbol, "");

            return sb.ToString();
        }

    }
}
