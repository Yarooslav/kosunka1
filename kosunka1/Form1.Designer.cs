namespace kosunka1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CardPictureBox = new System.Windows.Forms.PictureBox();
            this.lbl = new System.Windows.Forms.Label();
            this.pnlDeck = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTable = new System.Windows.Forms.FlowLayoutPanel();
            this.downpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlace = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlgame = new System.Windows.Forms.FlowLayoutPanel();
            this.toppanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.CardPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CardPictureBox
            // 
            this.CardPictureBox.Location = new System.Drawing.Point(12, 179);
            this.CardPictureBox.Name = "CardPictureBox";
            this.CardPictureBox.Size = new System.Drawing.Size(200, 70);
            this.CardPictureBox.TabIndex = 1;
            this.CardPictureBox.TabStop = false;
            this.CardPictureBox.Click += new System.EventHandler(this.CardPictureBox_Click);
            this.CardPictureBox.DoubleClick += new System.EventHandler(this.CardPictureBox_DoubleClick);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(77, 163);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 13);
            this.lbl.TabIndex = 3;
            // 
            // pnlDeck
            // 
            this.pnlDeck.Location = new System.Drawing.Point(12, 288);
            this.pnlDeck.Name = "pnlDeck";
            this.pnlDeck.Size = new System.Drawing.Size(184, 100);
            this.pnlDeck.TabIndex = 4;
            // 
            // pnlTable
            // 
            this.pnlTable.Location = new System.Drawing.Point(424, 240);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(293, 100);
            this.pnlTable.TabIndex = 5;
            // 
            // downpanel
            // 
            this.downpanel.Location = new System.Drawing.Point(218, 134);
            this.downpanel.Name = "downpanel";
            this.downpanel.Size = new System.Drawing.Size(509, 100);
            this.downpanel.TabIndex = 5;
            this.downpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPlayer1_Paint);
            // 
            // pnlace
            // 
            this.pnlace.Location = new System.Drawing.Point(406, 338);
            this.pnlace.Name = "pnlace";
            this.pnlace.Size = new System.Drawing.Size(311, 100);
            this.pnlace.TabIndex = 6;
            this.pnlace.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnlace_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kosunka1.Properties.Resources._1453486485176659442;
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlgame
            // 
            this.pnlgame.Location = new System.Drawing.Point(171, 28);
            this.pnlgame.Name = "pnlgame";
            this.pnlgame.Size = new System.Drawing.Size(68, 100);
            this.pnlgame.TabIndex = 8;
            this.pnlgame.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // toppanel
            // 
            this.toppanel.Location = new System.Drawing.Point(288, 28);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(418, 100);
            this.toppanel.TabIndex = 9;
            this.toppanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.pnlgame);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlace);
            this.Controls.Add(this.downpanel);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.pnlDeck);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.CardPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CardPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CardPictureBox;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.FlowLayoutPanel pnlDeck;
        private System.Windows.Forms.FlowLayoutPanel pnlTable;
        private System.Windows.Forms.FlowLayoutPanel downpanel;
        private System.Windows.Forms.FlowLayoutPanel pnlace;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel pnlgame;
        private System.Windows.Forms.FlowLayoutPanel toppanel;
    }
}

