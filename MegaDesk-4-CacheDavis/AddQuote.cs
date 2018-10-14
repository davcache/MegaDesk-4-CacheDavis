using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_CacheDavis
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();

            var materials = new List<Desk.DesktopMaterial>();

            materials = Enum.GetValues(typeof(Desk.DesktopMaterial))
            .Cast<Desk.DesktopMaterial>()
            .ToList();

            comMaterial.DataSource = materials;

            comMaterial.SelectedIndex = -1;

            //var shipping = new List<DeskQuote.Delivery>();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }
    }
}
