namespace REKTDICEGAME
{
    partial class GameField
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameField));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.savePointsBtn = new System.Windows.Forms.Button();
            this.rollBtn = new System.Windows.Forms.Button();
            this.pointsLbl = new System.Windows.Forms.Label();
            this.dice_0 = new System.Windows.Forms.PictureBox();
            this.dice_1 = new System.Windows.Forms.PictureBox();
            this.dice_2 = new System.Windows.Forms.PictureBox();
            this.dice_3 = new System.Windows.Forms.PictureBox();
            this.dice_4 = new System.Windows.Forms.PictureBox();
            this.strikeLbl = new System.Windows.Forms.Label();
            this.attemptsLbl = new System.Windows.Forms.Label();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.lastPointsLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playerLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maxPointsLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dice_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_4)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.savePointsBtn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.rollBtn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pointsLbl, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dice_0, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dice_1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dice_2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dice_3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dice_4, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.strikeLbl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.attemptsLbl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.newGameBtn, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lastPointsLbl, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.playerLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.maxPointsLbl, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.02198F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(768, 546);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // savePointsBtn
            // 
            this.savePointsBtn.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.savePointsBtn, 2);
            this.savePointsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savePointsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.savePointsBtn.Location = new System.Drawing.Point(3, 439);
            this.savePointsBtn.Name = "savePointsBtn";
            this.savePointsBtn.Size = new System.Drawing.Size(300, 104);
            this.savePointsBtn.TabIndex = 0;
            this.savePointsBtn.Text = "Save points";
            this.savePointsBtn.UseVisualStyleBackColor = true;
            this.savePointsBtn.Click += new System.EventHandler(this.savePointsBtn_Click);
            // 
            // rollBtn
            // 
            this.rollBtn.AutoSize = true;
            this.rollBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rollBtn.Location = new System.Drawing.Point(309, 265);
            this.rollBtn.Name = "rollBtn";
            this.rollBtn.Size = new System.Drawing.Size(147, 59);
            this.rollBtn.TabIndex = 1;
            this.rollBtn.Text = "Roll";
            this.rollBtn.UseVisualStyleBackColor = true;
            this.rollBtn.Click += new System.EventHandler(this.rollBtn_Click);
            // 
            // pointsLbl
            // 
            this.pointsLbl.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.pointsLbl, 2);
            this.pointsLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pointsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pointsLbl.Location = new System.Drawing.Point(462, 0);
            this.pointsLbl.Name = "pointsLbl";
            this.pointsLbl.Size = new System.Drawing.Size(303, 109);
            this.pointsLbl.TabIndex = 2;
            this.pointsLbl.Text = "0";
            this.pointsLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dice_0
            // 
            this.dice_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dice_0.Image = global::REKTDICEGAME.Properties.Resources.dice_blank;
            this.dice_0.InitialImage = ((System.Drawing.Image)(resources.GetObject("dice_0.InitialImage")));
            this.dice_0.Location = new System.Drawing.Point(3, 112);
            this.dice_0.Name = "dice_0";
            this.dice_0.Size = new System.Drawing.Size(147, 147);
            this.dice_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice_0.TabIndex = 3;
            this.dice_0.TabStop = false;
            this.dice_0.WaitOnLoad = true;
            // 
            // dice_1
            // 
            this.dice_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dice_1.Image = global::REKTDICEGAME.Properties.Resources.dice_blank;
            this.dice_1.Location = new System.Drawing.Point(156, 112);
            this.dice_1.Name = "dice_1";
            this.dice_1.Size = new System.Drawing.Size(147, 147);
            this.dice_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice_1.TabIndex = 4;
            this.dice_1.TabStop = false;
            // 
            // dice_2
            // 
            this.dice_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dice_2.Image = global::REKTDICEGAME.Properties.Resources.dice_blank;
            this.dice_2.Location = new System.Drawing.Point(309, 112);
            this.dice_2.Name = "dice_2";
            this.dice_2.Size = new System.Drawing.Size(147, 147);
            this.dice_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice_2.TabIndex = 5;
            this.dice_2.TabStop = false;
            // 
            // dice_3
            // 
            this.dice_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dice_3.Image = global::REKTDICEGAME.Properties.Resources.dice_blank;
            this.dice_3.Location = new System.Drawing.Point(462, 112);
            this.dice_3.Name = "dice_3";
            this.dice_3.Size = new System.Drawing.Size(147, 147);
            this.dice_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice_3.TabIndex = 6;
            this.dice_3.TabStop = false;
            // 
            // dice_4
            // 
            this.dice_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dice_4.Image = global::REKTDICEGAME.Properties.Resources.dice_blank;
            this.dice_4.Location = new System.Drawing.Point(615, 112);
            this.dice_4.Name = "dice_4";
            this.dice_4.Size = new System.Drawing.Size(150, 147);
            this.dice_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice_4.TabIndex = 7;
            this.dice_4.TabStop = false;
            // 
            // strikeLbl
            // 
            this.strikeLbl.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.strikeLbl, 5);
            this.strikeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strikeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.strikeLbl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.strikeLbl.Location = new System.Drawing.Point(3, 327);
            this.strikeLbl.Name = "strikeLbl";
            this.strikeLbl.Size = new System.Drawing.Size(762, 109);
            this.strikeLbl.TabIndex = 8;
            this.strikeLbl.Text = "!!! STRIKE !!!";
            this.strikeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.strikeLbl.Visible = false;
            // 
            // attemptsLbl
            // 
            this.attemptsLbl.AutoSize = true;
            this.attemptsLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attemptsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attemptsLbl.Location = new System.Drawing.Point(309, 0);
            this.attemptsLbl.Name = "attemptsLbl";
            this.attemptsLbl.Size = new System.Drawing.Size(147, 109);
            this.attemptsLbl.TabIndex = 9;
            this.attemptsLbl.Text = "0/10";
            this.attemptsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newGameBtn
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.newGameBtn, 2);
            this.newGameBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newGameBtn.Location = new System.Drawing.Point(462, 439);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(303, 104);
            this.newGameBtn.TabIndex = 10;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Visible = false;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // lastPointsLbl
            // 
            this.lastPointsLbl.AutoSize = true;
            this.lastPointsLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastPointsLbl.Location = new System.Drawing.Point(615, 262);
            this.lastPointsLbl.Name = "lastPointsLbl";
            this.lastPointsLbl.Size = new System.Drawing.Size(150, 65);
            this.lastPointsLbl.TabIndex = 11;
            this.lastPointsLbl.Text = "0";
            this.lastPointsLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(462, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 65);
            this.label1.TabIndex = 12;
            this.label1.Text = "Last";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // playerLbl
            // 
            this.playerLbl.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.playerLbl, 2);
            this.playerLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerLbl.Location = new System.Drawing.Point(3, 0);
            this.playerLbl.Name = "playerLbl";
            this.playerLbl.Size = new System.Drawing.Size(300, 109);
            this.playerLbl.TabIndex = 13;
            this.playerLbl.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 65);
            this.label2.TabIndex = 14;
            this.label2.Text = "Max";
            // 
            // maxPointsLbl
            // 
            this.maxPointsLbl.AutoSize = true;
            this.maxPointsLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxPointsLbl.Location = new System.Drawing.Point(156, 262);
            this.maxPointsLbl.Name = "maxPointsLbl";
            this.maxPointsLbl.Size = new System.Drawing.Size(147, 65);
            this.maxPointsLbl.TabIndex = 15;
            this.maxPointsLbl.Text = "0";
            this.maxPointsLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // GameField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 546);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GameField";
            this.Text = "GameField";
            this.Load += new System.EventHandler(this.GameField_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dice_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button savePointsBtn;
        private System.Windows.Forms.Button rollBtn;
        private System.Windows.Forms.Label pointsLbl;
        private System.Windows.Forms.PictureBox dice_0;
        private System.Windows.Forms.PictureBox dice_1;
        private System.Windows.Forms.PictureBox dice_2;
        private System.Windows.Forms.PictureBox dice_3;
        private System.Windows.Forms.PictureBox dice_4;
        private System.Windows.Forms.Label strikeLbl;
        private System.Windows.Forms.Label attemptsLbl;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Label lastPointsLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label maxPointsLbl;
    }
}