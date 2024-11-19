using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_CNPM
{
    public partial class RegiFace : Form
    {
        Image<Bgr, Byte> currentFrame;
        Capture grabber = null;
        HaarCascade face;
        string finalname;
        HaarCascade eye;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name, names = null;

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //Initialize the capture device
            grabber = new Capture();
            grabber.QueryFrame();
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            guna2Button3.Enabled = true;
            guna2Button2.Enabled = false;
        }

        public void changeColor(Color color, Color color2)
        {
            this.BackColor = color;
            if (color2 == Color.FromArgb(50, 50, 50))
            {
                guna2Button1.FillColor = color2;
                guna2Button1.ForeColor = Color.White;
                guna2Button2.FillColor = color2;
                guna2Button3.FillColor = color2;
            }
            else
            {
                guna2Button1.FillColor = Color.Silver;
                guna2Button1.ForeColor = Color.Black;
                guna2Button2.FillColor = Color.FromArgb(94, 148, 255);
                guna2Button3.FillColor = Color.FromArgb(94, 148, 255);
            }
        }
        public void changeLanguage(string language)
        {
            if (language == "Vietnam")
            {
                guna2Button1.Text = "Xóa FaceID";
                guna2Button2.Text = "Mở Camera";
                guna2Button3.Text = "Tạo FaceID";
            }
            else
            {
                guna2Button1.Text = "Delete FaceID";
                guna2Button2.Text = "Open Camera";
                guna2Button3.Text = "Create FaceID";
            }
        }
        private void RegiFace_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Idle -= new EventHandler(FrameGrabber);
            if (grabber != null)
                grabber.Dispose();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa faceid?", "OK", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                BLL.Face.XoaFace();
            }
        }

        private void FrameGrabber(object sender, EventArgs e)
        {
            //label4.Text = "";
            NamePersons.Add("");


            //Get the current frame form capture device
            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Convert it to Grayscale
            gray = currentFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
          face,
          1.2,
          10,
          Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
          new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                t = t + 1;
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //draw the face detected in the 0th (gray) channel with blue color
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);


                if (trainingImages.ToArray().Length != 0)
                {

                    //TermCriteria for face recognition with numbers of trained images like maxIteration
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                    //Eigen face recognizer
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                       trainingImages.ToArray(),
                       labels.ToArray(),
                       3000,
                       ref termCrit);

                    name = recognizer.Recognize(result);
                    // MessageBox.Show("" + name);
                    // textBox2.Text = name;
                    finalname = name;
                    //Draw the label for each face detected and recognized
                    currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));

                }

                NamePersons[t - 1] = name;
                NamePersons.Add("");

            }
            t = 0;

            //Names concatenation of persons recognized
            for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
            {
                names = names + NamePersons[nnn] + ", ";
            }
            Bitmap BmpInput = currentFrame.ToBitmap();
            //Show the faces procesed and recognized
            guna2PictureBox1.Image = BmpInput;

            names = "";
            //Clear the list(vector) of names
            NamePersons.Clear();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                //Trained face counter
                ContTrain = ContTrain + 1;

                //Get a gray frame from capture device
                gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //Face Detector
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                face,
                1.2,
                10,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));

                //Action for each element detected
                if (facesDetected[0].Length == 1)
                {
                    foreach (MCvAvgComp f in facesDetected[0])
                    {
                        TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                        break;
                    }

                    //resize face detected image for force to compare the same size with the 
                    //test image with cubic interpolation type method
                    TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    trainingImages.Add(TrainedFace);
                    labels.Add(Static.getUser().GetMaNhanVien());

                    //convert to binary
                    byte[] imageData = ConvertImageToByteArray(TrainedFace);
                    //store to sql
                    BLL.Face.SaveToSql(Static.getUser().GetMaNhanVien(), imageData);
                    MessageBox.Show(Static.getUser().GetMaNhanVien() + "Gương mặt đã được thêm", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thỏa mãn gương mặt");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public RegiFace()
        {
            InitializeComponent();
            //Load haarcascades for face detection
            face = new HaarCascade("haarcascade_frontalface_default.xml");
        }

        private byte[] ConvertImageToByteArray(Image<Gray, byte> image)
        {
            // Convert the image to a MemoryStream
            using (MemoryStream ms = new MemoryStream())
            {
                image.Bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                return ms.ToArray();
            }
        }
    }
}
