using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.OleDb;
using System.IO.Ports;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;


namespace ShapeDetect5
{
    public partial class Form1 : Form
    {
        Capture capture;
        String dataR;
        Int16 dem = 0;
        Int32 demLoi = 0;
        Int32 demTron = 0;
        Int32 demTG = 0;
        Int32 demVuong = 0;
        Int32 demCir = 0;
        Int32 demTri = 0;
        Int32 demSquad = 0;

        float compare = 0, acr = 0;
        long tong;
        Image<Bgr, byte> inputImage;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                MessageBox.Show("Đã ngắt kết nối");
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
            }

        }
        private void startCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (capture == null)
            {
                //capture = new Emgu.CV.Capture("http://192.168.1.17:4747/mjpegfeed?640x480");
                capture = new Emgu.CV.Capture(1);
            }
            capture.ImageGrabbed += capture_ImageGrabbed;
            capture.Start();
        }
        private void capture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                Mat m = new Mat();
                capture.Retrieve(m);
                imBCam.Image = m.ToImage<Bgr, byte>();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void stopCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                capture.Pause();
            }
        }

        private void exitFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            Int32 baudrate = Convert.ToInt32(cbbBaudRate.Text);
            serialPort1.BaudRate = baudrate;
            serialPort1.Open();
            if (serialPort1.IsOpen == true)
            {
                MessageBox.Show("Kết nối thành công");
            }
            serialPort1.DataReceived += serialPort1_DataReceived;
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            dataR = serialPort1.ReadTo("\r\n");
            if (dataR == "1")
            {
                dem++;
            }
            if (dem == 1)
            {
                DetectShape();
                dem = 0;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = SerialPort.GetPortNames();

            Control.CheckForIllegalCrossThreadCalls = false;
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
        }
        void DetectShape()
        {
            Int32 loiTron = 0;
            if (capture == null)
            {
                MessageBox.Show("Vui lòng bật camera để nhận dạng");
                return;
            }
            else
            {
                Mat mat = new Mat();
                mat = capture.QueryFrame();
                inputImage = mat.ToImage<Bgr, byte>();
                imBXuLy.Image = inputImage;
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Image<Gray, byte> uimage = new Image<Gray, byte>(inputImage.Width, inputImage.Height, new Gray(255));// Chuyển qua ảnh Xám
            Image<Gray, byte> gray = inputImage.Convert<Gray, byte>().PyrDown().PyrUp();  // Lọc nhiễu
            imXam.Image = gray;  // Show ảnh Xám
            gray = gray.ThresholdBinary(new Gray(150), new Gray(255));// Chuyển qua ảnh Nhị phân
            imNhiphan.Image = gray;  // Show ảnh Nhị phân
            uimage = inputImage.Canny(300,20);// Phát hiện cạnh
            imBien.Image = uimage;  // Show ảnh đường biên

            #region circle detection 
            // Phát hiện vòng Tròn
            Image<Gray, byte> gray1 = inputImage.Convert<Gray, byte>().PyrDown().PyrUp();  // Lọc nhiễu
            CircleF[] circles = gray1.HoughCircles(new Gray(180), new Gray(120), 2.0, 15.0, 5, 0)[0];
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



            #endregion
            List<Triangle2DF> triangleList = new List<Triangle2DF>();
            List<RotatedRect> boxList = new List<RotatedRect>(); //a box is a rotated rectangle              

            #region Find triangles and rectangles  
            // Tìm hình Tam giác và hình Chữ nhật
            //watch.Reset(); watch.Start();
            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                CvInvoke.FindContours(uimage, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);
                int count = contours.Size; 
                for (int i = 0; i < count; i++)
                {
                    using (VectorOfPoint contour = contours[i])
                    using (VectorOfPoint approxContour = new VectorOfPoint())
                    {
                        CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * 0.05, true);//Nối các cạnh tạo Đa giác
                        if (CvInvoke.ContourArea(approxContour, false) > 250) //only consider contours with area greater than 250 .tính diện tích của hình của đường viền và tham số mặc định là fault
                        {
                            if (approxContour.Size == 3) // Đường bao 3 đỉnh là Tam giác
                            {
                                Point[] pts = approxContour.ToArray();
                                triangleList.Add(new Triangle2DF(pts[0], pts[1], pts[2])); //thêm giá trị các điểm vào triangleList 
                                break;
                            }
                            else if (approxContour.Size == 4) // Đường bao có 4 đỉnh
                            {
                                #region determine if all the angles in the contour are within [80, 100] degree
                                //xác định xem tất cả các góc trong đường bao có nằm trong [80, 100] độ hay không
                                bool isRectangle = true; //bool isSquare = true;
                                Point[] pts = approxContour.ToArray();
                                LineSegment2D[] edges = PointCollection.PolyLine(pts, true);//Tạo một đoạn đường với điểm bắt đầu và điểm kết thúc cụ thể
                                //PointCollection.PolyLine =chuyển đổi một chuỗi System.Drawing.Point thành LineSegment2D
                                for (int j = 0; j < edges.Length; j++)
                                {
                                    double angle = Math.Abs(edges[(j + 1) % edges.Length].GetExteriorAngleDegree(edges[j]));
                                    if (angle < 85 || angle > 95) 
                                    {
                                        isRectangle = false;
                                        break;
                                    }
                                }
                                #endregion
                                if (isRectangle) boxList.Add(CvInvoke.MinAreaRect(approxContour));
                                //Finds a rotated rectangle of the minimum area enclosing the input 2D point .Tìm một hình chữ nhật xoay của vùng tối thiểu bao quanh bộ điểm đầu vào 2D.
                            }
                        }
                    }
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion
            #region draw triangles 
            // Vẽ hình Tam giác
            Image<Bgr, Byte> triangleImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
            if ((triangleList.Count() > 0) && (boxList.Count() == 0))
            {
                foreach (Triangle2DF triangle in triangleList)
                {
                    lbHinhDang.Text = "TAM GIÁC";
                    triangleImage.Draw(triangleList[0], new Bgr(Color.Yellow), 2);
                    demTG = 1;
                }
            }
            if (demTG == 1)
            {
                demTri++;
                lbTri.Text = demTri.ToString();
                demTG = 0;
                serialPort1.Write("3".ToString());
                imBNhanDang.Image = triangleImage;
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion
            #region draw Rectangle  
            // Vẽ hình Chữ nhật
            Image<Bgr, Byte> QuadImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);// inputImage.CopyBlank();
            if ((boxList.Count() > 0) && (triangleList.Count() == 0))
            {
                foreach (RotatedRect box in boxList)
                {
                    compare = Math.Abs((float)(boxList[0].Size.Height - boxList[0].Size.Width));
                    acr = boxList[0].Size.Height * boxList[0].Size.Width;
                    QuadImage.Draw(boxList[0], new Bgr(Color.Red), 2);
                    demVuong = 1;
                }
            }
            if (circles.Length == 0)
            {
                if (demVuong == 1)
                {
                    if (0.0 <= compare && compare <= 20)  // Hình Vuông
                    {
                        lbHinhDang.Text = "VUÔNG";
                        demSquad++;
                        lbSquad.Text = demSquad.ToString();
                        serialPort1.Write("4".ToString());
                        imBNhanDang.Image = QuadImage;
                        demVuong = 0;
                    }
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion
            #region draw circles  // Vẽ vòng Tròn
            Image<Bgr, Byte> circleImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
            foreach (CircleF circle in circles)
            {
                demTron = 1;
                circleImage.Draw(circles[0], new Bgr(Color.Blue), 2);
                lbHinhDang.Text = "TRÒN";
                loiTron = 1;
            }
            if (demTron == 1)
            {
                demCir++;
                lbCir.Text = demCir.ToString();
                serialPort1.Write("5".ToString());
                imBNhanDang.Image = circleImage;
                demTron = 0;
            }
            /////////////////////////////////////////////////////////////////////////
            if ((triangleList.Count() == 0) && (boxList.Count() == 0) && (loiTron == 0))
            {
                demLoi++;
                lbError.Text = demLoi.ToString();
                serialPort1.Write("7".ToString());
            }
            #endregion
            tong = demCir + demSquad + demTri + demLoi;
            lbTongSanPham.Text = tong.ToString();
        }
    }
}

