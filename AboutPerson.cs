using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML_JSON
{
    public partial class AboutPerson : Form
    {
        public string name
        {
            get { return nameLabel.Text; }
            set { nameLabel.Text = value; }
        }
        public string age
        {
            get { return ageLabel.Text; }
            set { ageLabel.Text = value; }
        }
        public string card 
        {
            get { return cardLabel.Text; }
            set { cardLabel.Text = value; }
        }
        public string temp1
        {
            get { return temp1Label.Text; }
            set { temp1Label.Text = value; }
        }
        public string year
        {
            get { return yearLabel.Text; }
            set { yearLabel.Text = value; }
        }
        public string status
        {
            get { return statusLabel.Text; }
            set { statusLabel.Text = value; }
        }

        public AboutPerson()
        {
            InitializeComponent();
        }

        private void AboutPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
