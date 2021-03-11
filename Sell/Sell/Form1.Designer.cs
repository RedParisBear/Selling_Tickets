namespace Sell
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ближайшиеМероприятияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискМероприятияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дляАдминистраторовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ближайшиеМероприятияToolStripMenuItem,
            this.поискМероприятияToolStripMenuItem,
            this.дляАдминистраторовToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ближайшиеМероприятияToolStripMenuItem
            // 
            this.ближайшиеМероприятияToolStripMenuItem.Name = "ближайшиеМероприятияToolStripMenuItem";
            this.ближайшиеМероприятияToolStripMenuItem.Size = new System.Drawing.Size(163, 36);
            this.ближайшиеМероприятияToolStripMenuItem.Text = "Ближайшие мероприятия";
            this.ближайшиеМероприятияToolStripMenuItem.Click += new System.EventHandler(this.ближайшиеМероприятияToolStripMenuItem_Click);
            // 
            // поискМероприятияToolStripMenuItem
            // 
            this.поискМероприятияToolStripMenuItem.Name = "поискМероприятияToolStripMenuItem";
            this.поискМероприятияToolStripMenuItem.Size = new System.Drawing.Size(131, 36);
            this.поискМероприятияToolStripMenuItem.Text = "Поиск мероприятия";
            this.поискМероприятияToolStripMenuItem.Click += new System.EventHandler(this.поискМероприятияToolStripMenuItem_Click);
            // 
            // дляАдминистраторовToolStripMenuItem
            // 
            this.дляАдминистраторовToolStripMenuItem.Name = "дляАдминистраторовToolStripMenuItem";
            this.дляАдминистраторовToolStripMenuItem.Size = new System.Drawing.Size(121, 36);
            this.дляАдминистраторовToolStripMenuItem.Text = "Администраторам";
            this.дляАдминистраторовToolStripMenuItem.Click += new System.EventHandler(this.дляАдминистраторовToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 36);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 362);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Продажа билетов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ближайшиеМероприятияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискМероприятияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дляАдминистраторовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

