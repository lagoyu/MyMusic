namespace MyMusic
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myMusicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myMusicDataSet = new MyMusic.MyMusicDataSet();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.cmbxSongID = new System.Windows.Forms.ComboBox();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSongID = new System.Windows.Forms.TextBox();
            this.myMusicTableAdapter = new MyMusic.MyMusicDataSetTableAdapters.MyMusicTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myMusicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myMusicDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // myMusicBindingSource
            // 
            this.myMusicBindingSource.DataMember = "MyMusic";
            this.myMusicBindingSource.DataSource = this.myMusicDataSet;
            // 
            // myMusicDataSet
            // 
            this.myMusicDataSet.DataSetName = "MyMusicDataSet";
            this.myMusicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(68, 346);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAll.TabIndex = 1;
            this.btnSaveAll.Text = "Save All";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // cmbxSongID
            // 
            this.cmbxSongID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxSongID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxSongID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.myMusicBindingSource, "Song Title", true));
            this.cmbxSongID.DataSource = this.myMusicBindingSource;
            this.cmbxSongID.DisplayMember = "Song Title";
            this.cmbxSongID.FormattingEnabled = true;
            this.cmbxSongID.Location = new System.Drawing.Point(159, 348);
            this.cmbxSongID.Name = "cmbxSongID";
            this.cmbxSongID.Size = new System.Drawing.Size(121, 21);
            this.cmbxSongID.TabIndex = 2;
            this.cmbxSongID.ValueMember = "Id";
            this.cmbxSongID.SelectedIndexChanged += new System.EventHandler(this.cmbxSongID_SelectedIndexChanged_1);
            // 
            // tbArtist
            // 
            this.tbArtist.Location = new System.Drawing.Point(512, 349);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(104, 20);
            this.tbArtist.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Song ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Artist";
            // 
            // tbSongID
            // 
            this.tbSongID.Location = new System.Drawing.Point(344, 349);
            this.tbSongID.Name = "tbSongID";
            this.tbSongID.Size = new System.Drawing.Size(100, 20);
            this.tbSongID.TabIndex = 6;
            // 
            // myMusicTableAdapter
            // 
            this.myMusicTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 401);
            this.Controls.Add(this.tbSongID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbArtist);
            this.Controls.Add(this.cmbxSongID);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "My Music";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myMusicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myMusicDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MyMusicDataSet myMusicDataSet;
        private System.Windows.Forms.BindingSource myMusicBindingSource;
        private MyMusicDataSetTableAdapters.MyMusicTableAdapter myMusicTableAdapter;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.ComboBox cmbxSongID;
        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSongID;
    }
}

