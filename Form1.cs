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

            DataView comboView = new DataView(myMusicDataSet.Tables["MyMusic"]);
            DataView gridView = new DataView(myMusicDataSet.Tables["MyMusic"]);
            
            
            // View used by cmbxSongID is sorted by Song title
            comboView.Sort = "[Song Title]";
            cmbxSongID.DataSource = comboView;

            // Display Titles but return ID values
            cmbxSongID.DisplayMember = "Song Title";
            cmbxSongID.ValueMember = "Id";
            
            // View used by GridView is sorted by Artist then Song Title
            gridView.Sort = "Artist, [Song Title]";
            dataGridView1.DataSource = gridView;

            // This line of code loads data into the 'myMusicDataSet.MyMusic' table which is used by both views. 
            this.myMusicTableAdapter.Fill(this.myMusicDataSet.MyMusic);


        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            this.myMusicTableAdapter.Update(this.myMusicDataSet.MyMusic);
            MessageBox.Show("Database saved","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }


        private void cmbxSongID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Display the selected ID
            int songID = int.Parse(cmbxSongID.SelectedValue.ToString());
            tbSongID.Text = songID.ToString();
            
            // Find Artist from matching row in DataSet based on selected ID
            DataRow row = myMusicDataSet.MyMusic.Rows.Find(cmbxSongID.SelectedValue);
            tbArtist.Text = row["Artist"].ToString();

            // TODO: Update the selected Artist in the dataset - Not working yet!
            //DataRow[] musicRow = myMusicDataSet.Tables["MyMusic"].Select("Id = " + songID);
            //musicRow[0]["Comment"] = "You picked this one!";
            //myMusicDataSet.MyMusic[songID].Comment = "You picked this one!";

        }

 
    }
}
