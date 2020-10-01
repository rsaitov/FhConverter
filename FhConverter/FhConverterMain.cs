using FhConverter.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FhConverter
{
    public partial class FhConverterMain : Form
    {
        IConverter converter;
        public FhConverterMain()
        {
            InitializeComponent();

            btnDecToHexConvert.Click += new System.EventHandler(ConvertDecToHex);
            btn7ByteConvert.Click += new System.EventHandler(Convert7ByteCrookedToStraight);
        }

        private void ConvertDecToHex(object sender, EventArgs e)
        {
            converter = new DecToHexConverter();
            var decs = txtPage1Dec.Text.Split(new char[] { '\r', '\n' }).ToList();
            var hexs = converter.Convert(decs);
            txtPage1Hex.Text = String.Join("\r\n", hexs);
        }

        private void Convert7ByteCrookedToStraight(object sender, EventArgs e)
        {
            converter = new SevenByteCrookedToStraightConverter();
            var crooked = txtPage2Crooked.Text.Split(new char[] { '\r', '\n' }).ToList();
            var straight = converter.Convert(crooked);
            txtPage2Straight.Text = String.Join("\r\n", straight);
        }
    }
}
