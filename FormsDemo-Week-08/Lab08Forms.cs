using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDemo_Week_08
{
    public partial class Lab08Forms : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }
        public Lab08Forms()
        {
            InitializeComponent();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = true;
        }

        private void Lab08Forms_Load(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = nameTextBox.Text;
            UserAge = float.Parse(ageTextBox.Text);
            OutputLabel.Text = nameTextBox.Text + ", " + ageTextBox.Text;
            nameTextBox.Text = string.Empty;
            ageTextBox.Text = string.Empty;
        }
    }
}
