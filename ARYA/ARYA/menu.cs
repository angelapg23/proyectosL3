using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARYA
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
     
            panelPlaylistSubMenu.Visible = false;
          panelToolsSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void login()
        {
            var formlogin = new Login();
            
            formlogin.ShowDialog();
        }

  

        private void menu_Load(object sender, EventArgs e)
        {
            login();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
        Application.Exit();
        }


        private void btnMedia_Click_1(object sender, EventArgs e)
        {

            hideSubMenu();
            var formorden = new Ordenes();
           
            formorden.Show();
            
        }

      

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Ordenes());
            hideSubMenu();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);

        }
        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {

        }


        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {

        }
        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {

        }
        private void button12_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form formulario = new Tecnicos();
            formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Clientes();
            formulario.Show();
        }
    }
}
