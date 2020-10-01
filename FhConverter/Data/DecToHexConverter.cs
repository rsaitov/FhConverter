using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FhConverter.Data
{
    public class DecToHexConverter : IConverter
    {
        public IEnumerable<string> Convert(IEnumerable<string> decs)
        {
            decs = decs.Where(x => x.Length > 0).Select(x => x.Trim().Replace(" ", "")).ToList();
            var hexs = decs.Select(decimalNumber =>
            {
                long number;
                var parseResult = long.TryParse(decimalNumber, out number);
                return number.ToString("x").ToUpper();
            }).ToList();

            return hexs;
        }
    }
}
