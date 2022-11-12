using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_DZ3.Task1
{
    public partial class TextEditor : Form
    {
        private string CurrentFilePath { get; set; }
        private Text FileText { get; set; }
        public TextEditor()
        {
            InitializeComponent();
            MainTextBox.ContextMenuStrip = contextMenuStrip;
            FileText = new Text(MainTextBox.Text, null, MainTextBox.Font, MainTextBox.ForeColor, MainTextBox.BackColor);
            CurrentFilePath = "";
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            
            this.Text = openFileDialog.FileName;
            using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
            using (StreamReader sr = new StreamReader(fs))
               FileText = new Text(sr.ReadToEnd());
            MainTextBox.Text = FileText.Current;
            CurrentFilePath = openFileDialog.FileName;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (openFileDialog.FileName == "")
                return;
            using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
            using (StreamWriter sr = new StreamWriter(fs))
            {
                sr.Write(MainTextBox.Text);
                this.FileText.Previous = null;
            }
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {

        }

        private void NewDocument_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            string s = MainTextBox.Text.Substring(MainTextBox.SelectionStart, MainTextBox.SelectionLength);
            if (s == "" || s == null)
                return;
            Clipboard.SetText(s);
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            string s = MainTextBox.Text.Substring(MainTextBox.SelectionStart, MainTextBox.SelectionLength);
            if (s == "" || s == null)
                return;
            int cursosPosition = MainTextBox.SelectionStart;
            Clipboard.SetText(s);
            MainTextBox.Text = MainTextBox.Text.Remove(MainTextBox.SelectionStart, MainTextBox.SelectionLength);
            MainTextBox.SelectionStart = cursosPosition;
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            int cursosPosition = MainTextBox.SelectionStart + Clipboard.GetText().Length;
            MainTextBox.Text = MainTextBox.Text.Insert(MainTextBox.SelectionStart, Clipboard.GetText());
            MainTextBox.SelectionStart = cursosPosition;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            var s = MainTextBox.SelectionStart;
            FileText.Cancel();

            MainTextBox.Text = FileText.Current;
            MainTextBox.Font = FileText.Font;
            MainTextBox.ForeColor = FileText.ForeColor;
            MainTextBox.BackColor = FileText.BackColor;

            MainTextBox.SelectionStart = s;
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            MainTextBox.SelectionStart = 0;
            MainTextBox.SelectionLength = MainTextBox.Text.Length;
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            if(!File.Exists(saveFileDialog.FileName))
                using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open | FileMode.Create))
                using (StreamWriter sr = new StreamWriter(fs))
                {
                    sr.Write(MainTextBox.Text);
                    this.FileText.Previous = null;
                }
        }

        private void ChangeFont_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            MainTextBox.Font = fontDialog.Font;
            FileText.Font = fontDialog.Font;
        }

        private void ChangeFontColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            MainTextBox.ForeColor = colorDialog.Color;
            FileText.ForeColor = colorDialog.Color;
        }

        private void ChangeBackColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            MainTextBox.BackColor = colorDialog.Color;
            FileText.BackColor = colorDialog.Color;
        }

        private void MainTextBox_TextChanged(object sender, EventArgs e)
        {
            FileText.Previous = FileText.Clone();
            FileText.Current = MainTextBox.Text;
        }
    }
}
