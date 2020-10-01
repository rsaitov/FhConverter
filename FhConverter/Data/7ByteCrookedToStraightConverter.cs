using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FhConverter.Data
{
    public class SevenByteCrookedToStraightConverter : IConverter
    {
        public IEnumerable<string> Convert(IEnumerable<string> crooked)
        {
            crooked = crooked.Where(x => x.Length > 0).Select(x => x.Trim().Replace(" ", "")).ToList();

            var bytes = crooked.Select(item => {
                if (item.Length != 14)
                    return "";

                var crookedSequence = new List<string> { 
                    string.Format("{0}{1}", item[0], item[1]),
                    string.Format("{0}{1}", item[2], item[3]),
                    string.Format("{0}{1}", item[4], item[5]),
                    string.Format("{0}{1}", item[6], item[7]),
                    string.Format("{0}{1}", item[8], item[9]),
                    string.Format("{0}{1}", item[10], item[11]),
                    string.Format("{0}{1}", item[12], item[13])
                };

                var straightSequence = new List<string> {
                    crookedSequence[4],
                    crookedSequence[5],
                    crookedSequence[6],
                    crookedSequence[0],
                    crookedSequence[1],
                    crookedSequence[2],
                    crookedSequence[3],
                };

                return string.Join("", straightSequence);
            });

            return bytes;
        }
    }
}
