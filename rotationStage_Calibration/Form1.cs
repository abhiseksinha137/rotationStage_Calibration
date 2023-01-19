using Emgu.CV;
using Emgu.CV.Cuda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rotationStage_Calibration
{
    public partial class Form1 : Form
    {

        bool stopAcq = false;
        Mat sourceImg;
        Mat CurrentImg;
        bool compare = false;
        int camNum;
        //double alpha;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartCam_Click(object sender, EventArgs e)
        {
            stopAcq= true;
            startCam();
        }

        public void startCam()
        {
            stopAcq = false;
            VideoCapture capture = new VideoCapture(camNum);
            //Application.Idle += ProcessFrame;
            capture.Start();
            capture.ImageGrabbed += (sender, e) => frameUpdated(sender, e, capture); // Lambda expression
                                                                                     // to pass the parameter to the event handler
        }


        private void frameUpdated(object sender, EventArgs e, VideoCapture capture)
        {
            if (!stopAcq)
            {
                Mat cap2 = capture.QueryFrame();
                Bitmap bmp = cap2.ToBitmap();
                CurrentImg = cap2;
                updatePicBox(cap2.ToBitmap(), picBx1); 

                if (compare)
                {
                    Mat dummy = CurrentImg;
                    Mat outputImg=new Mat();
                    double alpha = 0.5;
                    double beta = 1 - alpha;
                    CvInvoke.AddWeighted(sourceImg, alpha, dummy, beta, 0, outputImg);
                    updatePicBox(outputImg.ToBitmap(), picBx2);
                }
            }
            else
            {
                capture.Stop();
            }


        }

        public void updatePicBox(Bitmap img, PictureBox picBx)
        {
            if (chkBxFlip.CheckState == CheckState.Checked)
                img.RotateFlip(RotateFlipType.RotateNoneFlipX);

            picBx.Image = img;
            picBx.SizeMode = PictureBoxSizeMode.Zoom;

        }


        private void updateImage(object sender, EventArgs e, VideoCapture capture)
        {
            throw new NotImplementedException();
        }

        private void btnStopCam_Click(object sender, EventArgs e)
        {
            stopAcq = true;
            compare = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbbxCamNum.SelectedIndex = 0;
        }

        private void btnCapure_Click(object sender, EventArgs e)
        {
            //alpha = trackBar1.Value / 100;
            sourceImg = CurrentImg;
            compare = true;
        }

        private void cmbbxCamNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            camNum = cmbbxCamNum.SelectedIndex;
        }
    }
}
