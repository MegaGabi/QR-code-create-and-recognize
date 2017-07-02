using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        private Bitmap          bitmapQR;
        private QRCodeEncoder encoder;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (sender == b_CreateQR)
            {
                if (encoder == null)
                {
                    encoder = new QRCodeEncoder(); //создаём новую "генерацию кода"
                }
                    
                bitmapQR = encoder.Encode(tb.Text); // кодируем слово
                pictureBox1.Image = new Bitmap(bitmapQR);

                if (bitmapQR != null)
                {
                    bitmapQR.Dispose();
                }
            }
            else if (sender == b_Recognise)
            {
                if (pictureBox1.Image != null)
                {
                    bitmapQR = new Bitmap(pictureBox1.Image);

                    QRCodeDecoder decoder = new QRCodeDecoder(); // создаём "раскодирование изображения"

                    QRCodeBitmapImage qrImg = new QRCodeBitmapImage(bitmapQR);

                    string rez = decoder.Decode(qrImg);
                    bitmapQR.Dispose();

                    tb.Text = rez;
                }
            }
            else if (sender == b_LoadQR)
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string path = ofd.FileName;

                    pictureBox1.Image = Image.FromFile(path);
                }
            }
            else if (sender == b_SaveQR)
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string path = sfd.FileName;

                    pictureBox1.Image.Save(path, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }
    }
}
