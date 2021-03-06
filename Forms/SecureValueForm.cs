﻿using System;
using System.Globalization;
using System.Windows.Forms;

namespace ACSE
{
    public partial class SecureValueForm : Form
    {
        public SecureValueForm()
        {
            InitializeComponent();
        }

        public void Set_Secure_NAND_Value(ulong value)
        {
            textBox1.Text = value.ToString("X16");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MainForm.Save_File != null && (MainForm.Save_File.Save_Generation == SaveGeneration.N3DS))
            {
                if (ulong.TryParse(textBox1.Text, NumberStyles.AllowHexSpecifier, null, out ulong Secure_NAND_Value))
                {
                    MainForm.Save_File.Write(0, Secure_NAND_Value);
                }
            }
            Hide();
        }
    }
}
