using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clue
{
    public partial class Suggest : Form
    {
        // In Form1, change the access modifier of btnSug to public
        public Button btnSug;
        public Suggest()
        {
            InitializeComponent();
        }


        private void btnSuggest_Click(object sender, EventArgs e)
        {
            // Get the selected suspect, weapon, and room
            string suspect = cmbChara.SelectedItem.ToString();
            string weapon = cmbItems.SelectedItem.ToString();
            string room = txbRoom.Text;
            // Create a suggestion string
            string suggestion = $"추리: {suspect}이(가) {weapon}을(를) {room}에서 사용했습니다.";
            // Display the suggestion in a message box
            MessageBox.Show(suggestion, "추리", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

    }
}
