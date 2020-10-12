namespace FhConverter
{
    partial class FhConverterMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FhConverterMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageDecToHex = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPage1Dec = new System.Windows.Forms.RichTextBox();
            this.txtPage1Hex = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDecToHexConvert = new System.Windows.Forms.Button();
            this.btnHexToDecConvert = new System.Windows.Forms.Button();
            this.tabPage7ByteChange = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPage2Crooked = new System.Windows.Forms.RichTextBox();
            this.txtPage2Straight = new System.Windows.Forms.RichTextBox();
            this.btn7ByteConvert = new System.Windows.Forms.Button();
            this.tabPagePhoneNormalizer = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPage3PhonesAbnormal = new System.Windows.Forms.RichTextBox();
            this.txtPage3PhonesNormal = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPhoneNormalizerConvert = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPageDecToHex.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage7ByteChange.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPagePhoneNormalizer.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabMain, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(769, 620);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPageDecToHex);
            this.tabMain.Controls.Add(this.tabPage7ByteChange);
            this.tabMain.Controls.Add(this.tabPagePhoneNormalizer);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(3, 3);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 2;
            this.tabMain.Size = new System.Drawing.Size(763, 614);
            this.tabMain.TabIndex = 0;
            // 
            // tabPageDecToHex
            // 
            this.tabPageDecToHex.Controls.Add(this.tableLayoutPanel2);
            this.tabPageDecToHex.Location = new System.Drawing.Point(4, 24);
            this.tabPageDecToHex.Name = "tabPageDecToHex";
            this.tabPageDecToHex.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDecToHex.Size = new System.Drawing.Size(755, 586);
            this.tabPageDecToHex.TabIndex = 0;
            this.tabPageDecToHex.Text = "DecToHex";
            this.tabPageDecToHex.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPage1Dec, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtPage1Hex, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(749, 580);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Decimal (10 CC)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hexademical (16 CC)";
            // 
            // txtPage1Dec
            // 
            this.txtPage1Dec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPage1Dec.Location = new System.Drawing.Point(3, 23);
            this.txtPage1Dec.Name = "txtPage1Dec";
            this.txtPage1Dec.Size = new System.Drawing.Size(323, 554);
            this.txtPage1Dec.TabIndex = 5;
            this.txtPage1Dec.Text = "";
            // 
            // txtPage1Hex
            // 
            this.txtPage1Hex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPage1Hex.Location = new System.Drawing.Point(422, 23);
            this.txtPage1Hex.Name = "txtPage1Hex";
            this.txtPage1Hex.Size = new System.Drawing.Size(324, 554);
            this.txtPage1Hex.TabIndex = 6;
            this.txtPage1Hex.Text = "";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnDecToHexConvert, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnHexToDecConvert, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(332, 23);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(84, 100);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // btnDecToHexConvert
            // 
            this.btnDecToHexConvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecToHexConvert.Location = new System.Drawing.Point(3, 3);
            this.btnDecToHexConvert.Name = "btnDecToHexConvert";
            this.btnDecToHexConvert.Size = new System.Drawing.Size(78, 23);
            this.btnDecToHexConvert.TabIndex = 2;
            this.btnDecToHexConvert.Text = ">>";
            this.btnDecToHexConvert.UseVisualStyleBackColor = true;
            // 
            // btnHexToDecConvert
            // 
            this.btnHexToDecConvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHexToDecConvert.Location = new System.Drawing.Point(3, 32);
            this.btnHexToDecConvert.Name = "btnHexToDecConvert";
            this.btnHexToDecConvert.Size = new System.Drawing.Size(78, 23);
            this.btnHexToDecConvert.TabIndex = 3;
            this.btnHexToDecConvert.Text = "<<";
            this.btnHexToDecConvert.UseVisualStyleBackColor = true;
            // 
            // tabPage7ByteChange
            // 
            this.tabPage7ByteChange.Controls.Add(this.tableLayoutPanel3);
            this.tabPage7ByteChange.Location = new System.Drawing.Point(4, 24);
            this.tabPage7ByteChange.Name = "tabPage7ByteChange";
            this.tabPage7ByteChange.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7ByteChange.Size = new System.Drawing.Size(755, 586);
            this.tabPage7ByteChange.TabIndex = 1;
            this.tabPage7ByteChange.Text = "7ByteCrookedToStraight";
            this.tabPage7ByteChange.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtPage2Crooked, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtPage2Straight, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn7ByteConvert, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(749, 580);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Crooked (04 05 06 07 01 02 03)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Straight (01 02 03 04 05 06 07)";
            // 
            // txtPage2Crooked
            // 
            this.txtPage2Crooked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPage2Crooked.Location = new System.Drawing.Point(3, 23);
            this.txtPage2Crooked.Name = "txtPage2Crooked";
            this.txtPage2Crooked.Size = new System.Drawing.Size(323, 554);
            this.txtPage2Crooked.TabIndex = 2;
            this.txtPage2Crooked.Text = "";
            // 
            // txtPage2Straight
            // 
            this.txtPage2Straight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPage2Straight.Location = new System.Drawing.Point(422, 23);
            this.txtPage2Straight.Name = "txtPage2Straight";
            this.txtPage2Straight.Size = new System.Drawing.Size(324, 554);
            this.txtPage2Straight.TabIndex = 3;
            this.txtPage2Straight.Text = "";
            // 
            // btn7ByteConvert
            // 
            this.btn7ByteConvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn7ByteConvert.Location = new System.Drawing.Point(332, 23);
            this.btn7ByteConvert.Name = "btn7ByteConvert";
            this.btn7ByteConvert.Size = new System.Drawing.Size(84, 23);
            this.btn7ByteConvert.TabIndex = 4;
            this.btn7ByteConvert.Text = ">>";
            this.btn7ByteConvert.UseVisualStyleBackColor = true;
            // 
            // tabPagePhoneNormalizer
            // 
            this.tabPagePhoneNormalizer.Controls.Add(this.tableLayoutPanel5);
            this.tabPagePhoneNormalizer.Location = new System.Drawing.Point(4, 24);
            this.tabPagePhoneNormalizer.Name = "tabPagePhoneNormalizer";
            this.tabPagePhoneNormalizer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePhoneNormalizer.Size = new System.Drawing.Size(755, 586);
            this.tabPagePhoneNormalizer.TabIndex = 2;
            this.tabPagePhoneNormalizer.Text = "Phone Normalizer";
            this.tabPagePhoneNormalizer.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.txtPage3PhonesAbnormal, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtPage3PhonesNormal, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnPhoneNormalizerConvert, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(749, 580);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // txtPage3PhonesAbnormal
            // 
            this.txtPage3PhonesAbnormal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPage3PhonesAbnormal.Location = new System.Drawing.Point(3, 23);
            this.txtPage3PhonesAbnormal.Name = "txtPage3PhonesAbnormal";
            this.txtPage3PhonesAbnormal.Size = new System.Drawing.Size(323, 554);
            this.txtPage3PhonesAbnormal.TabIndex = 0;
            this.txtPage3PhonesAbnormal.Text = "";
            // 
            // txtPage3PhonesNormal
            // 
            this.txtPage3PhonesNormal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPage3PhonesNormal.Location = new System.Drawing.Point(422, 23);
            this.txtPage3PhonesNormal.Name = "txtPage3PhonesNormal";
            this.txtPage3PhonesNormal.Size = new System.Drawing.Size(324, 554);
            this.txtPage3PhonesNormal.TabIndex = 1;
            this.txtPage3PhonesNormal.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Abnormal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Normal";
            // 
            // btnPhoneNormalizerConvert
            // 
            this.btnPhoneNormalizerConvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPhoneNormalizerConvert.Location = new System.Drawing.Point(332, 23);
            this.btnPhoneNormalizerConvert.Name = "btnPhoneNormalizerConvert";
            this.btnPhoneNormalizerConvert.Size = new System.Drawing.Size(84, 23);
            this.btnPhoneNormalizerConvert.TabIndex = 4;
            this.btnPhoneNormalizerConvert.Text = ">>";
            this.btnPhoneNormalizerConvert.UseVisualStyleBackColor = true;
            // 
            // FhConverterMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 620);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FhConverterMain";
            this.Text = "FH Converter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPageDecToHex.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tabPage7ByteChange.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPagePhoneNormalizer.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageDecToHex;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnDecToHexConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage7ByteChange;
        private System.Windows.Forms.RichTextBox txtPage1Dec;
        private System.Windows.Forms.RichTextBox txtPage1Hex;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtPage2Crooked;
        private System.Windows.Forms.RichTextBox txtPage2Straight;
        private System.Windows.Forms.Button btn7ByteConvert;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnHexToDecConvert;
        private System.Windows.Forms.TabPage tabPagePhoneNormalizer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.RichTextBox txtPage3PhonesAbnormal;
        private System.Windows.Forms.RichTextBox txtPage3PhonesNormal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPhoneNormalizerConvert;
    }
}