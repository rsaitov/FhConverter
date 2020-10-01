using System;
using System.Collections.Generic;
using System.Text;

namespace FhConverter.Data
{
    interface IConverter
    {
        public IEnumerable<string> Convert(IEnumerable<string> list);
    }
}
