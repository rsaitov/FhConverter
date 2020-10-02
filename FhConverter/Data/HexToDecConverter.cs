using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FhConverter.Data
{
    public class HexToDecConverter : IConverter
    {
        public IEnumerable<string> Convert(IEnumerable<string> hexs)
        {            
            hexs = hexs.Where(x => x.Length > 0).Select(x => x.Trim().Replace(" ", "")).ToList();
            var decs = hexs.Select(hexNumber =>
            {
                //long number;
                //var parseResult = long.TryParse(decimalNumber, out number);
                //return number.ToString("x").ToUpper();

                long decNumber = long.Parse(hexNumber, System.Globalization.NumberStyles.HexNumber);
                return decNumber.ToString();
            }).ToList();

            return decs;
        }
    }
}
