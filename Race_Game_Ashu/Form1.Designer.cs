namespace Race_Game_Ashu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FirstContestant = new System.Windows.Forms.PictureBox();
            this.secndContestant = new System.Windows.Forms.PictureBox();
            this.thrdContestant = new System.Windows.Forms.PictureBox();
            this.ForthContestant = new System.Windows.Forms.PictureBox();
            this.Players = new System.Windows.Forms.CheckedListBox();
            this.BetDetails = new System.Windows.Forms.ListBox();
            this.Contestant = new System.Windows.Forms.NumericUpDown();
            this.Amount = new System.Windows.Forms.NumericUpDown();
            this.btnDetails = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstContestant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secndContestant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thrdContestant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForthContestant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contestant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FirstContestant
            // 
            this.FirstContestant.Image = ((System.Drawing.Image)(resources.GetObject("FirstContestant.Image")));
            this.FirstContestant.Location = new System.Drawing.Point(0, 253);
            this.FirstContestant.Name = "FirstContestant";
            this.FirstContestant.Size = new System.Drawing.Size(55, 31);
            this.FirstContestant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FirstContestant.TabIndex = 1;
            this.FirstContestant.TabStop = false;
            // 
            // secndContestant
            // 
            this.secndContestant.Image = ((System.Drawing.Image)(resources.GetObject("secndContestant.Image")));
            this.secndContestant.Location = new System.Drawing.Point(-2, 320);
            this.secndContestant.Name = "secndContestant";
            this.secndContestant.Size = new System.Drawing.Size(55, 31);
            this.secndContestant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secndContestant.TabIndex = 2;
            this.secndContestant.TabStop = false;
            // 
            // thrdContestant
            // 
            this.thrdContestant.Image = ((System.Drawing.Image)(resources.GetObject("thrdContestant.Image")));
            this.thrdContestant.Location = new System.Drawing.Point(0, 383);
            this.thrdContestant.Name = "thrdContestant";
            this.thrdContestant.Size = new System.Drawing.Size(55, 31);
            this.thrdContestant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thrdContestant.TabIndex = 3;
            this.thrdContestant.TabStop = false;
            // 
            // ForthContestant
            // 
            this.ForthContestant.Image = ((System.Drawing.Image)(resources.GetObject("ForthContestant.Image")));
            this.ForthContestant.Location = new System.Drawing.Point(0, 451);
            this.ForthContestant.Name = "ForthContestant";
            this.ForthContestant.Size = new System.Drawing.Size(55, 31);
            this.ForthContestant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ForthContestant.TabIndex = 4;
            this.ForthContestant.TabStop = false;
            // 
            // Players
            // 
            this.Players.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Players.FormattingEnabled = true;
            this.Players.Items.AddRange(new object[] {
            "Ashu got 200 Dollar in his Account",
            "Gagan got 220 Dollar in his Account",
            "Sukh has 210 Dollar in his Account"});
            this.Players.Location = new System.Drawing.Point(12, 30);
            this.Players.Name = "Players";
            this.Players.Size = new System.Drawing.Size(382, 94);
            this.Players.TabIndex = 5;
            this.Players.SelectedIndexChanged += new System.EventHandler(this.Players_SelectedIndexChanged);
            // 
            // BetDetails
            // 
            this.BetDetails.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetDetails.FormattingEnabled = true;
            this.BetDetails.Location = new System.Drawing.Point(400, 30);
            this.BetDetails.Name = "BetDetails";
            this.BetDetails.Size = new System.Drawing.Size(398, 95);
            this.BetDetails.TabIndex = 6;
            // 
            // Contestant
            // 
            this.Contestant.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contestant.Location = new System.Drawing.Point(27, 137);
            this.Contestant.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Contestant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Contestant.Name = "Contestant";
            this.Contestant.Size = new System.Drawing.Size(130, 26);
            this.Contestant.TabIndex = 7;
            this.Contestant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Amount
            // 
            this.Amount.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(227, 139);
            this.Amount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(130, 26);
            this.Amount.TabIndex = 8;
            this.Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDetails.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.Location = new System.Drawing.Point(421, 133);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(98, 32);
            this.btnDetails.TabIndex = 9;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.Details_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStart.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(583, 133);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(136, 32);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start Race";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fill Contestant No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fill Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Contestant);
            this.Controls.Add(this.BetDetails);
            this.Controls.Add(this.Players);
            this.Controls.Add(this.ForthContestant);
            this.Controls.Add(this.thrdContestant);
            this.Controls.Add(this.secndContestant);
            this.Controls.Add(this.FirstContestant);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstContestant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secndContestant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thrdContestant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForthContestant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contestant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox FirstContestant;
        private System.Windows.Forms.PictureBox secndContestant;
        private System.Windows.Forms.PictureBox thrdContestant;
        private System.Windows.Forms.PictureBox ForthContestant;
        private System.Windows.Forms.CheckedListBox Players;
        private System.Windows.Forms.ListBox BetDetails;
        private System.Windows.Forms.NumericUpDown Contestant;
        private System.Windows.Forms.NumericUpDown Amount;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

