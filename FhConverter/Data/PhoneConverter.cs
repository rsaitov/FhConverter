using FhConverter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FhConverter.Data
{
    public class PhoneConverter : IConverter
    {
        public IEnumerable<string> Convert(IEnumerable<string> list)
        {
            var phonesAbnormal = list.ToList();
            var phonesNormal = phonesAbnormal.Select(phoneAbnormal => 
            {
                try
                {
                    var phone = new Phone(phoneAbnormal);
                    return string.Format("{0}{1}", phone.Code, phone.Number);
                }
                catch(Exception ex)
                {
                    return ex.Message;
                }

            });

            return phonesNormal;
        }
    }
}
