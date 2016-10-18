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
            this.myMusicTableAdapter = new MyMusic.MyMusicDataSetTableAdapters.MyMusicTableAdapter();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.cmbxSongID = new System.Windows.Forms.ComboBox();
            this.tbSongTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myMusicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myMusicDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.songTitleDataGridViewTextBoxColumn,
            this.artistDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.myMusicBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(592, 285);
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
            // myMusicTableAdapter
            // 
            this.myMusicTableAdapter.ClearBeforeFill = true;
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
            this.cmbxSongID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.myMusicBindingSource, "Song Title", true));
            this.cmbxSongID.FormattingEnabled = true;
            this.cmbxSongID.Location = new System.Drawing.Point(220, 348);
            this.cmbxSongID.Name = "cmbxSongID";
            this.cmbxSongID.Size = new System.Drawing.Size(121, 21);
            this.cmbxSongID.TabIndex = 2;
            this.cmbxSongID.SelectedIndexChanged += new System.EventHandler(this.cmbxSongID_SelectedIndexChanged_1);
            // 
            // tbSongTitle
            // 
            this.tbSongTitle.Location = new System.Drawing.Point(448, 349);
            this.tbSongTitle.Name = "tbSongTitle";
            this.tbSongTitle.Size = new System.Drawing.Size(100, 20);
            this.tbSongTitle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Song ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Song Title";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // songTitleDataGridViewTextBoxColumn
            // 
            this.songTitleDataGridViewTextBoxColumn.DataPropertyName = "Song Title";
            this.songTitleDataGridViewTextBoxColumn.HeaderText = "Song Title";
            this.songTitleDataGridViewTextBoxColumn.Name = "songTitleDataGridViewTextBoxColumn";
            // 
            // artistDataGridViewTextBoxColumn
            // 
            this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
            this.artistDataGridViewTextBoxColumn.HeaderText = "Artist";
            this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "Release Date";
            this.releaseDateDataGridViewTextBoxColumn.HeaderText = "Release Date";
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSongTitle);
            this.Controls.Add(this.cmbxSongID);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox tbSongTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}

