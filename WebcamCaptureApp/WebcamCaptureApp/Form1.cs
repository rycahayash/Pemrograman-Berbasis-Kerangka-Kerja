using AForge.Video;
using AForge.Video.DirectShow;

namespace WebcamCaptureApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private VideoCaptureDevice videoCapture;
        FilterInfoCollection filterInfo;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonStartCamera_Click(object sender, EventArgs e)
        {
            startCamera();

        }

        private void startCamera()
        {
            try
            {
                filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                videoCapture = new VideoCaptureDevice(filterInfo[6].MonikerString);
                videoCapture.NewFrame += new NewFrameEventHandler(Camera_on);
                videoCapture.Start();

            }
            catch (Exception e)
            {

            }
        }

        private void Camera_on(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void buttonCapture_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
            // filename location

            string filename = @"D:\ITS\Semester 6\PBKK\" + textBox1.Text + ".jpg";

            var bitmap = new Bitmap(pictureBox2.Width, pictureBox2.Height);

            pictureBox2.DrawToBitmap(bitmap, pictureBox2.ClientRectangle);

            System.Drawing.Imaging.ImageFormat imageFormat = null;

            imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;

            // save the image

            bitmap.Save(filename);
        }
    }
}