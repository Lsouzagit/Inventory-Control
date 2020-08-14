using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Inventory_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void customizeDesign()
        {
            panelMediaSubmenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelTools.Visible = false;
        }
        private void hideSubmenu()
        {
            if(panelMediaSubmenu.Visible == true)
            {
                panelMediaSubmenu.Visible = false;
            }
            else if(panelPlaylistSubMenu.Visible == true)
            {
                panelPlaylistSubMenu.Visible = false;
            }
            else
            {
                panelTools.Visible = false;
            }
        }
        private void showSubmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubmenu(panelMediaSubmenu);
        }
        #region submenu buttons

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            //.. code
            hideSubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //.. code
            hideSubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //.. code
            hideSubmenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //.. code
            hideSubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //.. code
            hideSubmenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //.. code
            hideSubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //.. code
            hideSubmenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //.. code
            hideSubmenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //.. code
            hideSubmenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //.. code
            hideSubmenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //.. code
            hideSubmenu();
        }
        #endregion

        private void bntPlaylist_Click(object sender, EventArgs e)
        {
            showSubmenu(panelPlaylistSubMenu);
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubmenu(panelTools);
        }

        private void bntEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            //code
            hideSubmenu();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
