using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GameApp
{
    public partial class VocabularyList : Form
    {
        string newWord;
        public VocabularyList()
        {
            InitializeComponent();


        }
        string[] path = { };

        private void VocabularyList_Load(object sender, EventArgs e)
        {
            listView.View = View.Details;
            listView.Columns.Add("Word", 200);
            listView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            populate();
        }


        //Load images
        private void populate()
        {

            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(120, 120);

            path = Directory.GetFiles(@"E:\Winform C#\Lab2\GameApp\GameApp\bin\Debug\Images\fruit\");
            try
            {
                foreach (string pathItem in path)
                {
                    imageList.Images.Add(Image.FromFile(pathItem));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); return;
            }
            listView.SmallImageList = imageList;
            for (int i = 0; i < imageList.Images.Count; i++)
            {
                listView.Items.Add(Path.GetFileNameWithoutExtension(path[i]), i);
            }
        }
        // Open home
        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
        //Back to vocabulary
        private void button4_Click(object sender, EventArgs e)
        {
            Vocabulary vocabulary = new Vocabulary();
            vocabulary.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                           "All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                newWord = Path.GetFullPath(openFileDialog1.FileName);
                pictureBox1.Image = Image.FromFile(Path.GetFullPath(openFileDialog1.FileName));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Drawing.Image image = System.Drawing.Image.FromFile(newWord);
            string pathToSave = "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\fruit\\";
            // Create a new folder to save the image in.
            string extension = Path.GetExtension(newWord);
            // Save the image to the folder.
            string fileName = tbWord.Text + extension;
            image.Save(Path.Combine(pathToSave, fileName));
            MessageBox.Show("Add successfully");
            pictureBox1.Image = Image.FromFile("E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Icon\\default.png");
            listView.Items.Clear();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string selectedindex = listview.selecteditems[0].subitems[0].text;
            // Clear the selected item.
            path = Directory.GetFiles(@"E:\Winform C#\Lab2\GameApp\GameApp\bin\Debug\Images\fruit\");
            string nameOfFile = listView.SelectedItems[0].Text;
            string fileToDelete = "";
            for (int i = 0; i < path.Count(); i++)
            {
                if (path[i].Contains(nameOfFile))
                {
                    fileToDelete = path[i];
                    path = path.Where(o => o != path[i]).ToArray();
                }
            }
            listView.Items.Clear();
            if (File.Exists(fileToDelete))
            {

                // Delete the file.
                File.Delete(fileToDelete);
            }
            else
            {
                // File does not exist.
                MessageBox.Show("File does not exist.");
            }
            populate();

        }
    }
}
