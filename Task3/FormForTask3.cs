using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_DZ3.Task3;

public partial class FormForTask3 : Form
{
    public FormForTask3()
    {
        InitializeComponent();
    }

    private void btAddSubmenu_Click(object sender, EventArgs e)
    {
        try
        {
            if (TopLevelMenu.Text != "")
            {
                ToolStripMenuItem topLevelItem = (ToolStripMenuItem)menuStrip.Items[TopLevelMenu.Text];
                menuStrip.Items.Remove(topLevelItem);
                if (SubItem.Text != "")
                {
                    ToolStripMenuItem subLevelItem = new ToolStripMenuItem(SubItem.Text);
                    topLevelItem.DropDownItems.Add(subLevelItem);
                }
                else
                    throw new Exception("SubLevelMenu is empty");

                menuStrip.Items.Add(topLevelItem);
            }
            else
                throw new Exception("TopLevelMenu is empty");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btAddMenuItem_Click(object sender, EventArgs e)
    {
        menuStrip.Items.Add(TopLevelMenu.Text);
        var a = menuStrip.Items[menuStrip.Items.Count - 1].Name = TopLevelMenu.Text;
    }

    private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
    }
}


