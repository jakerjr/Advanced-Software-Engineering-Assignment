using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment1
{
    public partial class Form1 : Form
    {
        Bitmap outputBitmap = new Bitmap(640, 480);
        Commands commands;

        public Form1()
        {
            InitializeComponent();
            commands = new Commands(Graphics.FromImage(outputBitmap));

            outputCanvas.Image = outputBitmap;
        }

        /// <summary>
        /// This is the text box used to execute commands.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void commandLine_KeyDown(object sender, KeyEventArgs e)
        {
            // commands are entered after pressing the Enter key.
            if (e.KeyCode == Keys.Enter)
            {
                String consoleInput = commandLine.Text.ToLower();
                // Checks if the user put in the run function. This will run the commands inside the RichTextBox
                if (consoleInput.Equals("run"))
                {
                    String[] runCommands = multiCommandLine.Lines;

                    for (int x = 0; x < runCommands.Length; x++)
                    {
                        String test = runCommands[x].ToLower();
                        commands.executeCommands(test);
                        Refresh();
                    }
                }
                else
                {
                    commands.executeCommands(consoleInput);
                }
                // Empties the text box after pressing enter.
                commandLine.Text = "";
                Refresh();
            }
        }

        /// <summary>
        /// Shows the output of the commands.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void outputCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(outputBitmap, 0, 0);
        }

        /// <summary>
        /// Executes commands in the RichTextBox after pressing Enter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            String[] runCommands = multiCommandLine.Lines;

            // A loop is used to read each line of the RichTextBox
            for (int x = 0; x < runCommands.Length; x++)
            {
                String test = runCommands[x].ToLower();
                commands.executeCommands(test);
                Refresh();
            }
        }

        /// <summary>
        /// Checks whether the commands inside the RichTextBox are valid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Syntax_Click(object sender, EventArgs e)
        {
            String[] runCommands = multiCommandLine.Lines;

            for (int x = 0; x < runCommands.Length; x++)
            {
                String test = runCommands[x].ToLower();
                commands.executeCommands(test);
                commands.CommandError(x);
                Refresh();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            saveFD.FileName = "Save Image";
            saveFD.Filter = "JPEG|*.jpeg";

            if (saveFD.ShowDialog() != DialogResult.Cancel)
            {
                string savePath = saveFD.FileName;

                Bitmap OutputBitmap = new Bitmap(outputCanvas.Image);

                OutputBitmap.Save(savePath, ImageFormat.Jpeg);

                MessageBox.Show("Image Saved");


            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "bmp files (.JPEG)|.jpeg";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                outputCanvas.Image = Image.FromFile(dlg.FileName);
            }
            dlg.Dispose();
        }
    }
}