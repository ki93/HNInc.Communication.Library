using HNInc.Communication.Library;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;


namespace WpfImageTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HNSocketIO hNSocketIO;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //hNSocketIO = new HNSocketIO();
            //hNSocketIO.Connect();
            //while (!hNSocketIO.IsConnected())
            //{
            //    hNSocketIO.SendData(EventNames.RTLoadData);
            //    hNSocketIO.SendData(EventNames.RTLossData);
            //}
            //hNSocketIO.ReceiveQualityJudgmentProgresStart();
            //hNSocketIO.ReceiveQualityJudgmentProgressEnd();
            //hNSocketIO.QualityJudgmentProgresEndEvent += Input_Image;
            MessageBoxResult result= MessageBox.Show("Hello, world!", "HN Inc", MessageBoxButton.OK, MessageBoxImage.Error);
            Debug.WriteLine(result);
            string currentPath = AppDomain.CurrentDomain.BaseDirectory;
            string recentImageNamePath = Path.Combine(currentPath, @"RecentImageName\");
            if (!Directory.Exists(recentImageNamePath))
            {
                Directory.CreateDirectory(recentImageNamePath);
            }
            string fileName = "RecentImageName.txt";
            string recentImageNameFilePath = Path.Combine(recentImageNamePath, fileName);
            if (!File.Exists(recentImageNameFilePath))
            {
                FileStream fileStream = File.Create(recentImageNameFilePath);
                fileStream.Close();
            }
            string temp1 = "test1";
            string temp2 = "test3";

            string imageName1 = $"{temp1},{temp2}";
            File.WriteAllText(recentImageNameFilePath, imageName1);
            string readImageName1 = File.ReadAllText(recentImageNameFilePath);
            Debug.WriteLine(readImageName1);
            string[] vs = readImageName1.Split(",");
            Debug.WriteLine(vs[0]);
            Debug.WriteLine(vs[1]);
            //File.WriteAllText(recentImageNameFilePath, String.Empty);
            //string readImageName2 = File.ReadAllText(recentImageNameFilePath);
            //Debug.WriteLine(readImageName2);
            //string imageName2 = "test2";
            //File.WriteAllText(recentImageNameFilePath, imageName2);
            //string readImageName3 = File.ReadAllText(recentImageNameFilePath);
            //Debug.WriteLine(readImageName3);
            //string imagePath = Path.Combine(currentPath, @"Image\");
            //string failImagePath = Path.Combine(imagePath, "fail-to-save-Image.png");
            //Image.Source = new BitmapImage(new Uri(failImagePath, UriKind.Absolute));
        }


        private async void Input_Image(string eventname, object e)
        {
            Quality quality = (Quality)e;
            //not null 처리 필요
            Debug.WriteLine(quality._imageBytes.Length);
            MemoryStream memoryStream = new MemoryStream(quality._imageBytes);
            Debug.WriteLine(memoryStream.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(memoryStream);
            string currentPath = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(currentPath, @"Image\");
            bool checkPath = Directory.Exists(imagePath);

            if (!checkPath)
            {
                Directory.CreateDirectory(imagePath);
            }
            string path = Path.Combine(imagePath, quality._fileName);
            Debug.WriteLine(path);
            image.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
            image.Dispose();
            memoryStream.Flush();
            memoryStream.Dispose();
            memoryStream.Close();


            await Task.Factory.StartNew(() =>
            {
                this.Dispatcher.BeginInvoke(DispatcherPriority.Normal,
                    (ThreadStart)delegate ()
                    {
                        UiText1.Text = currentPath;
                        UiText2.Text = imagePath;
                        UiText3.Text = checkPath.ToString();
                        Image.Source = new BitmapImage(new Uri(path, UriKind.Absolute));
                    });
            });
        }
    }
}
