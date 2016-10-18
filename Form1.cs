using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMusic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Fill Combobox from
            //cmbxSongID.Items.Clear();
            // DataView musicView = new DataView(myMusicDataSet.Tables["MyMusic"], " ","ID, [Song Title]",DataViewRowState.CurrentRows);
            DataView comboView = new DataView(myMusicDataSet.Tables["MyMusic"]);
            comboView.Sort = "Artist, [Song Title]";
            cmbxSongID.DataSource = comboView;
            cmbxSongID.DisplayMember = "Song Title";
            cmbxSongID.ValueMember = "Id";
            cmbxSongID.ResetBindings();

            DataView gridView = new DataView(myMusicDataSet.Tables["MyMusic"]);
            gridView.Sort = "Artist, [Song Title]";
            dataGridView1.DataSource = gridView;

            
            // TODO: This line of code loads data into the 'myMusicDataSet.MyMusic' table. You can move, or remove it, as needed.
            this.myMusicTableAdapter.Fill(this.myMusicDataSet.MyMusic);



        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            this.myMusicTableAdapter.Update(this.myMusicDataSet.MyMusic);
        }


        private void cmbxSongID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            tbSongTitle.Text = cmbxSongID.SelectedValue.ToString();
        }
 
    }
}
