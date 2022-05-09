using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace WF_Text_Editor
{
    public partial class Form1 : Form
    {
        InstalledFontCollection f_col;
        public Form1()
        {
            InitializeComponent();
            f_col = new InstalledFontCollection();
            foreach (var item in f_col.Families)
            {
                f_box.Items.Add(item.Name);
            }
            f_box.SelectedItem = "Times New Roman";
            s_box.SelectedItem = "14";
            richTextBox1.SelectionFont = new Font(f_col.Families[f_box.SelectedIndex], Convert.ToInt32(s_box.SelectedItem.ToString()));
            msEn.Visible = false;
            richTextBox1.Clear();
        }
        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text.CompareTo("Сменить язык") == 0)
            {
                
                button1.Text = "Change Lang";
                msRu.Visible = false;
                msEn.Visible = true;
                this.MainMenuStrip = msEn;
            }
            else
            {
                button1.Text = "Сменить язык";
                msEn.Visible = false;
                msRu.Visible = true;
                this.MainMenuStrip = msRu;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
                newToolStripButton_Click(this, new EventArgs());
            
                OpenFile.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    if (OpenFile.FileName == "") return;
                    else
                    {
                        using (StreamReader str = new StreamReader(OpenFile.FileName))
                        { richTextBox1.Text = str.ReadToEnd(); }
                    }
                }
            
        }

        private void Safe_Click(object sender, EventArgs e)
        {
            SafeFile1.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";
            SafeFile1.FilterIndex = 0;
            if (SafeFile1.ShowDialog() == DialogResult.OK)
            {
                if (SafeFile1.FileName == "") return;
                else
                {
                    using (StreamWriter str = new StreamWriter(SafeFile1.FileName))
                    {
                        str.Write(richTextBox1.Text);
                    }
                }
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "" && button1.Text == "Сменить язык")
            {
                DialogResult res = MessageBox.Show("Вы хотите сохранить изменения в файле?", "Блокнот", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Safe_Click(this, new EventArgs());
                    richTextBox1.Clear();
                }
                if (res == DialogResult.No)
                    richTextBox1.Clear();
            }
            if(richTextBox1.Text != "" && button1.Text == "Change Lang")
            {
                DialogResult res = MessageBox.Show("Save this changes in file?", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Safe_Click(this, new EventArgs());
                    richTextBox1.Clear();
                }
                if (res == DialogResult.No)
                    richTextBox1.Clear();
            }
        }

        private void f_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f_box.SelectedIndex != -1 && s_box.SelectedIndex!=-1 )
            {
                richTextBox1.SelectionFont = new Font(f_col.Families[f_box.SelectedIndex], Convert.ToInt32(s_box.SelectedItem.ToString()));
            }
        }

        private void s_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f_box.SelectedIndex != -1 && s_box.SelectedIndex != -1)
            {
                richTextBox1.SelectionFont = new Font(f_col.Families[f_box.SelectedIndex], Convert.ToInt32(s_box.SelectedItem.ToString()));
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                
                richTextBox1.Cut();
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                
                richTextBox1.Copy();
            }
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText!="")
            {
                Cutbt.Enabled = true;
                Copybt.Enabled = true;
                ruCopy.Enabled = true;
                ruCut.Enabled = true;
            }
            else
            {
                Cutbt.Enabled = false;
                Copybt.Enabled = false;
                ruCopy.Enabled = false;
                ruCut.Enabled = false;
            }
        }

        private void BoldBt_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Style != FontStyle.Bold)
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
            else
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont,FontStyle.Regular);
        }

        private void ItalBt_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Style != FontStyle.Italic)
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic);
            else
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
        }

        private void UndLBt_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Style != FontStyle.Underline)
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline);
            else
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
        }

        private void LeftAbt_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
        }

        private void CenterAbt_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }

        }

        private void RightAlbt_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            }
        }

        private void Colbt_Click(object sender, EventArgs e)
        {
            Color_D.Color = richTextBox1.SelectionColor;
            if (Color_D.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = Color_D.Color;
            }    
        }
    }
}
