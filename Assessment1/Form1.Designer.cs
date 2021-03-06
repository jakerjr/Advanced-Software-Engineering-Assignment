
namespace Assessment1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputCanvas = new System.Windows.Forms.PictureBox();
            this.commandLine = new System.Windows.Forms.TextBox();
            this.multiCommandLine = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Syntax = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.outputCanvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputCanvas
            // 
            this.outputCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputCanvas.Location = new System.Drawing.Point(421, 62);
            this.outputCanvas.Name = "outputCanvas";
            this.outputCanvas.Size = new System.Drawing.Size(367, 319);
            this.outputCanvas.TabIndex = 0;
            this.outputCanvas.TabStop = false;
            this.outputCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.outputCanvas_Paint);
            // 
            // commandLine
            // 
            this.commandLine.Location = new System.Drawing.Point(13, 404);
            this.commandLine.Name = "commandLine";
            this.commandLine.Size = new System.Drawing.Size(775, 23);
            this.commandLine.TabIndex = 1;
            this.commandLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commandLine_KeyDown);
            // 
            // multiCommandLine
            // 
            this.multiCommandLine.Location = new System.Drawing.Point(13, 62);
            this.multiCommandLine.Name = "multiCommandLine";
            this.multiCommandLine.Size = new System.Drawing.Size(402, 319);
            this.multiCommandLine.TabIndex = 2;
            this.multiCommandLine.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Syntax
            // 
            this.Syntax.Location = new System.Drawing.Point(95, 433);
            this.Syntax.Name = "Syntax";
            this.Syntax.Size = new System.Drawing.Size(75, 23);
            this.Syntax.TabIndex = 4;
            this.Syntax.Text = "Syntax";
            this.Syntax.UseVisualStyleBackColor = true;
            this.Syntax.Click += new System.EventHandler(this.Syntax_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.Syntax);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.multiCommandLine);
            this.Controls.Add(this.commandLine);
            this.Controls.Add(this.outputCanvas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.outputCanvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox outputCanvas;
        private System.Windows.Forms.TextBox commandLine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox multiCommandLine;
        private System.Windows.Forms.Button Syntax;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.OpenFileDialog openFD;
    }
}
