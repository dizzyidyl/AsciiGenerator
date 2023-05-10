using System.Windows.Forms;

namespace newAscii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //tool strip open file button
            OpenFile();
        }

        public void OpenFile()
        {
            //clear previous image 
            tempPic.Image = null;

            ofd.Title = "Open Image";
            ofd.FileName = " ";

            //filters to image files
            ofd.Filter = "Image Files | *.jpg; *.jpeg; *.png;";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                //display image in picture box
                tempPic.Image = new Bitmap(ofd.FileName);

                try
                {
                    //convert image in picturebox to bmp
                    tempPic.Image = new Bitmap(ofd.FileName);
                    tempPic.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Select an image file!", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }//end open file function

        private void convert_Click(object sender, EventArgs e)
        {
            //calls Bitmap Ascii class
            Bitmap bmp = new(tempPic.Image);
            BitmapAscii pic = new();

            //places the result into the rich text box
            richTextBox1.Text = BitmapAscii.Asciitize(bmp, (int)numericUpDown1.Value, (int)numericUpDown2.Value);
        }
    }
}




