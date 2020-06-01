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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CardPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CardPictureBox
            // 
            this.CardPictureBox.Location = new System.Drawing.Point(16, 220);
            this.CardPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CardPictureBox.Name = "CardPictureBox";
            this.CardPictureBox.Size = new System.Drawing.Size(267, 86);
            this.CardPictureBox.TabIndex = 1;
            this.CardPictureBox.TabStop = false;
            this.CardPictureBox.Click += new System.EventHandler(this.CardPictureBox_Click);
            this.CardPictureBox.DoubleClick += new System.EventHandler(this.CardPictureBox_DoubleClick);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(103, 201);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 17);
            this.lbl.TabIndex = 3;
            // 
            // pnlDeck
            // 
            this.pnlDeck.Location = new System.Drawing.Point(16, 354);
            this.pnlDeck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDeck.Name = "pnlDeck";
            this.pnlDeck.Size = new System.Drawing.Size(245, 123);
            this.pnlDeck.TabIndex = 4;
            // 
            // pnlTable
            // 
            this.pnlTable.Location = new System.Drawing.Point(565, 295);
            this.pnlTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(391, 123);
            this.pnlTable.TabIndex = 5;
            // 
            // downpanel
            // 
            this.downpanel.Location = new System.Drawing.Point(291, 165);
            this.downpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.downpanel.Name = "downpanel";
            this.downpanel.Size = new System.Drawing.Size(679, 123);
            this.downpanel.TabIndex = 5;
            this.downpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPlayer1_Paint);
            // 
            // pnlace
            // 
            this.pnlace.Location = new System.Drawing.Point(541, 416);
            this.pnlace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlace.Name = "pnlace";
            this.pnlace.Size = new System.Drawing.Size(415, 123);
            this.pnlace.TabIndex = 6;
            this.pnlace.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnlace_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kosunka1.Properties.Resources._1453486485176659442;
            this.pictureBox1.Location = new System.Drawing.Point(57, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlgame
            // 
            this.pnlgame.Location = new System.Drawing.Point(228, 34);
            this.pnlgame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlgame.Name = "pnlgame";
            this.pnlgame.Size = new System.Drawing.Size(91, 123);
            this.pnlgame.TabIndex = 8;
            this.pnlgame.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(374, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 100);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(486, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(84, 100);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(590, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(103, 100);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(716, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(102, 100);
            this.panel4.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlgame);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlace);
            this.Controls.Add(this.downpanel);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.pnlDeck);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.CardPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

