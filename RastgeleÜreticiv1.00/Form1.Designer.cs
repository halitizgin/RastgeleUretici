namespace RastgeleÜreticiv1._00
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçileniKopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hepsiniKopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rastgeleÜreticiYardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpDosyasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLDosyasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 314);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(384, 41);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adet:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(12, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(384, 212);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sayı";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Üretilen";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yardımToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.yardımToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(415, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.yardımToolStripMenuItem.Text = "Dosya";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Image = global::RastgeleÜreticiv3._00.Properties.Resources._1397782213_04_Save_16x16;
            this.kaydetToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçileniKopyalaToolStripMenuItem,
            this.hepsiniKopyalaToolStripMenuItem});
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // seçileniKopyalaToolStripMenuItem
            // 
            this.seçileniKopyalaToolStripMenuItem.Image = global::RastgeleÜreticiv3._00.Properties.Resources._1397782415_App_Services_copy_Amazon_CloudSearch_SDF_metadata;
            this.seçileniKopyalaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.seçileniKopyalaToolStripMenuItem.Name = "seçileniKopyalaToolStripMenuItem";
            this.seçileniKopyalaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.seçileniKopyalaToolStripMenuItem.Text = "Seçileni Kopyala";
            this.seçileniKopyalaToolStripMenuItem.Click += new System.EventHandler(this.seçileniKopyalaToolStripMenuItem_Click);
            // 
            // hepsiniKopyalaToolStripMenuItem
            // 
            this.hepsiniKopyalaToolStripMenuItem.Image = global::RastgeleÜreticiv3._00.Properties.Resources._1397782316_icon_ios7_copy_outline;
            this.hepsiniKopyalaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hepsiniKopyalaToolStripMenuItem.Name = "hepsiniKopyalaToolStripMenuItem";
            this.hepsiniKopyalaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.hepsiniKopyalaToolStripMenuItem.Text = "Hepsini Kopyala";
            this.hepsiniKopyalaToolStripMenuItem.Click += new System.EventHandler(this.hepsiniKopyalaToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem1
            // 
            this.yardımToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rastgeleÜreticiYardımToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem1.Name = "yardımToolStripMenuItem1";
            this.yardımToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem1.Text = "Yardım";
            // 
            // rastgeleÜreticiYardımToolStripMenuItem
            // 
            this.rastgeleÜreticiYardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpDosyasıToolStripMenuItem,
            this.hTMLDosyasıToolStripMenuItem});
            this.rastgeleÜreticiYardımToolStripMenuItem.Image = global::RastgeleÜreticiv3._00.Properties.Resources._1397782459_Help;
            this.rastgeleÜreticiYardımToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rastgeleÜreticiYardımToolStripMenuItem.Name = "rastgeleÜreticiYardımToolStripMenuItem";
            this.rastgeleÜreticiYardımToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.rastgeleÜreticiYardımToolStripMenuItem.Text = "Rastgele Üretici Yardım";
            this.rastgeleÜreticiYardımToolStripMenuItem.Click += new System.EventHandler(this.rastgeleÜreticiYardımToolStripMenuItem_Click_1);
            // 
            // helpDosyasıToolStripMenuItem
            // 
            this.helpDosyasıToolStripMenuItem.Name = "helpDosyasıToolStripMenuItem";
            this.helpDosyasıToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.helpDosyasıToolStripMenuItem.Text = "Help Dosyası";
            this.helpDosyasıToolStripMenuItem.Click += new System.EventHandler(this.helpDosyasıToolStripMenuItem_Click);
            // 
            // hTMLDosyasıToolStripMenuItem
            // 
            this.hTMLDosyasıToolStripMenuItem.Name = "hTMLDosyasıToolStripMenuItem";
            this.hTMLDosyasıToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.hTMLDosyasıToolStripMenuItem.Text = "HTML Dosyası";
            this.hTMLDosyasıToolStripMenuItem.Click += new System.EventHandler(this.hTMLDosyasıToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Image = global::RastgeleÜreticiv3._00.Properties.Resources._1397782480_Information;
            this.hakkındaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.hakkındaToolStripMenuItem.Text = "Rastgele Üretici Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(20, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "------>";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::RastgeleÜreticiv3._00.Properties.Resources._1397774515_arrow_switch;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(321, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Üret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Rastgele Üretici v3.00";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçileniKopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hepsiniKopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem rastgeleÜreticiYardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpDosyasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTMLDosyasıToolStripMenuItem;
    }
}

