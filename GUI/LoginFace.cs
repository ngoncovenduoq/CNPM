using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace Project_CNPM
{
    public partial class LoginFace : Form
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

        private void LoginFace_Load(object sender, EventArgs e)
        {

        }

        string name, names = null;
        private string taikhoan;

        public LoginFace(string taikhoan)
        {
            InitializeComponent();
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            try
            {
                labels = BLL.Face.Name();
                trainingImages = BLL.Face.RetrieveFromSql();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.taikhoan = taikhoan;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Idle -= new EventHandler(FrameGrabber);
            if (grabber != null)
            {
                grabber.Dispose();
            }
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Initialize the capture device
            grabber = new Capture();
            grabber.QueryFrame();
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            guna2Button1.Enabled = false;
        }
        void FrameGrabber(object sender, EventArgs e)
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
                    finalname = name;
                    //Draw the label for each face detected and recognized
                    currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));

                }

                NamePersons[t - 1] = name;
                NamePersons.Add("");


            }
            t = 0;
            if(NamePersons.Count == 1)
            {
                if (NamePersons[0].Equals(taikhoan))
                {
                    Application.Idle -= new EventHandler(FrameGrabber);
                    DTO.User user = BLL.User.GetUser(taikhoan);
                    Static.changeUser(user);
                    if (taikhoan[0] == 'B')
                    {
                        Doctor doctor = new Doctor();
                        doctor.Show();
                        this.Hide();
                    }
                    else if (taikhoan[0] == 'L')
                    {
                        Receptionist receptionist = new Receptionist();
                        receptionist.Show();
                        this.Hide();
                    }
                    else
                    {
                        Owner owner = new Owner();
                        owner.Show();
                        this.Hide();
                    }
                }
            }
            Bitmap BmpInput = currentFrame.ToBitmap();
            guna2PictureBox1.Image = BmpInput;
            names = "";
            //Clear the list(vector) of names
            NamePersons.Clear();

        }
    }
}
