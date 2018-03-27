using Ozeki.Camera;
using Ozeki.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameCaptureApp
{
    public partial class Form1 : Form
    {
        private List<FrameCapture> frameCaptures = new List<FrameCapture>();

        private List<IIPCamera> cameras = new List<IIPCamera>();
        private string[] ips = new string[] { "rtsp://192.168.1.105:554/videoMain",
                                              "rtsp://192.168.1.106:554/videoMain",
                                              "rtsp://192.168.1.107:554/videoMain",
                                              "rtsp://192.168.1.108:554/videoMain" };
        private List<MediaConnector> connectors = new List<MediaConnector>(); 
        private List<DrawingImageProvider> imageProviders = new List<DrawingImageProvider>();
        private List<MPEG4Recorder> recorders = new List<MPEG4Recorder>();
        //private int _index = 0;

        public Form1()
        {
            InitializeComponent();
            //Initialize video component essentials
            for(int i = 0; i < 4; i++)
            {
                imageProviders.Add(new DrawingImageProvider());
                frameCaptures.Add(new FrameCapture());
                connectors.Add(new MediaConnector());
            }
        }

        private void connectBt_Click(object sender, EventArgs args)
        {
            try
            {
                disconnectBt.Enabled = true;
                startBt.Enabled = true;

                //Connect to the cameras
                for(int i = 0; i < 4; i++)
                {
                    cameras.Add(IPCameraFactory.GetCamera(ips[i], "madiZ", "2150183Mkz#"));
                    cameras[i].CameraStateChanged += OnCameraStateChanged;
                    cameras[i].CameraErrorOccurred += OnCameraErrorOccurred;
                    //connect to liveProviders
                    //connectors[i].Connect(cameras[i].VideoChannel, imageProviders[i]);
                    //connectors[i].Connect(cameras[i].VideoChannel, frameCaptures[i]);
                }


                //_camera1 = IPCameraFactory.GetCamera("rtsp://192.168.1.105:554/videoMain","madiZ","2150183Mkz#");
                //_camera1.CameraStateChanged += OnCameraStateChanged;
                //_camera1.CameraErrorOccurred += OnCameraErrorOccurred;
                //_connector.Connect(_camera1.VideoChannel, _liveProvider);
                //_connector.Connect(_camera1.VideoChannel, _capture);

                /*liveViewer.SetImageProvider(imageProviders[0]);
                liveViewer.Start();
                liveViewer2.SetImageProvider(imageProviders[1]);
                liveViewer2.Start();
                liveViewer3.SetImageProvider(imageProviders[2]);
                liveViewer3.Start();
                liveViewer4.SetImageProvider(imageProviders[3]);
                liveViewer4.Start();*/

                for(int i=0; i<4; i++)
                {
                    cameras[i].Start();
                }
                connectBt.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnCameraStateChanged(object sender, CameraStateEventArgs e)
        {

            Console.WriteLine("State Changed to: "+ e.State.ToString());
        }

        private void OnCameraErrorOccurred(object sender, CameraErrorEventArgs e)
        {
            Console.WriteLine("Error occurred: "+ e.ToString());
            Console.WriteLine("Error occurred: "+ e.Error.ToString());
        }

        private void disconnectBt_Click(object sender, EventArgs args)
        {
            try
            {


                for (int i = 0; i < 4; i++)
                {
                    frameCaptures[i].Stop();
                    frameCaptures[i].OnFrameCaptured -= _capture_onFrameCaptured;
                    cameras[i].Stop();
                    connectors[i].Disconnect(cameras[i].VideoChannel, imageProviders[i]);
                    connectors[i].Disconnect(cameras[i].VideoChannel, frameCaptures[i]);
                }
                //_capture.Stop();
                //_capture4.Stop();
                //_camera2.Stop();
                //_camera4.Stop();

                //_connector.Disconnect(_camera2.VideoChannel, _liveProvider);
                //_connector.Disconnect(_camera2.VideoChannel, _capture);

                //_connector4.Disconnect(_camera4.VideoChannel, _frameCaptureProvider);
                //_connector4.Disconnect(_camera4.VideoChannel, _capture4);

                //_connector.Disconnect(_capture, _frameCaptureProvider);


                liveViewer.Stop();
                liveViewer2.Stop();
                liveViewer3.Stop();
                liveViewer4.Stop();
                for(int i = 0; i < 4; i++)
                {
                    frameCaptures[i].Dispose();
                }
                connectBt.Enabled = true;
                disconnectBt.Enabled = false;

                startBt.Enabled = false;
                stopBt.Enabled = false;
            } catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void startBt_Click(object sender, EventArgs args)
        {
            try {
                var sec = int.Parse(secondText.Text);
                string date = DateTime.Now.Month + "m-" + DateTime.Now.Day + "d-" + DateTime.Now.Hour + "h-" + DateTime.Now.Minute 
                    +"min-"+DateTime.Now.Second+"sec-"+DateTime.Now.Millisecond+"millis";
                var defaultPath = "C:\\Users\\madiz\\Desktop\\videoCollection";

                for (int i = 0; i < 4; i++)
                {


                    recorders.Add(new MPEG4Recorder(defaultPath + "\\" + date + "_" + ips[i]));
                    recorders[i].MultiplexFinished += Mpeg4Recorder_MultiplexFinished;
                    connectors[i].Connect(cameras[i].AudioChannel, recorders[i].AudioRecorder);
                    connectors[i].Connect(cameras[i].VideoChannel, recorders[i].VideoRecorder);
                    // This is listener assignment to check each frames datestamp
                    // Was added for checking the SDK
                    //frameCaptures[i].SetInterval(new TimeSpan(0, 0, 0, sec));
                    //frameCaptures[i].Start();
                    //frameCaptures[i].OnFrameCaptured += _capture_onFrameCaptured;
                }
                //_capture.SetInterval(new TimeSpan(0, 0, 0, sec));
                //_capture.Start();
                //_capture.OnFrameCaptured += _capture_onFrameCaptured;
                stopBt.Enabled = true;
                startBt.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Mpeg4Recorder_MultiplexFinished(object sender, VoIPEventArgs<bool> e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (recorders[i] != null)
                {
                    connectors[i].Disconnect(cameras[i].AudioChannel, recorders[i].AudioRecorder);
                    connectors[i].Disconnect(cameras[i].VideoChannel, recorders[i].VideoRecorder);
                    recorders[i].Dispose();
                }
            }
        }

        //This method called whenever the application receives a frame from cameras
        //Probably need to distinguish between cameras
        //TODO: Save it to local distro as media file.
        private void _capture_onFrameCaptured(object sender, Ozeki.Media.Snapshot snapshot)
        {
            //var image = snapshot.ToImage();
            //image.Save("test" + _index + ".jpg");
            //Console.WriteLine(snapshot.DateStamp.ToString());
            //Console.WriteLine(snapshot.VideoData.Timestamp.ToString());
        }

        private void stopBt_Click(object sender, EventArgs args)
        {

            for (int i = 0; i < 4; i++)
            {
                if (recorders[i] != null)
                {
                    recorders[i].Multiplex();
                    connectors[i].Disconnect(cameras[i].AudioChannel, recorders[i].AudioRecorder);
                    connectors[i].Disconnect(cameras[i].VideoChannel, recorders[i].VideoRecorder);
                }
            }
            for (int i = 0; i < 4; i++)
            {
                frameCaptures[i].Stop();
                frameCaptures[i].OnFrameCaptured -= _capture_onFrameCaptured;
            }
            //_capture.Stop();
            //_capture.OnFrameCaptured -= _capture_onFrameCaptured;
            startBt.Enabled = true;
            stopBt.Enabled = false;
        }


    }
}
