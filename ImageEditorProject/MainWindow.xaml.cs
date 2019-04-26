using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace ImageEditorProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private SaveFileDialog saveFile = new SaveFileDialog();
        Bitmap bmpimage;

        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Edit button is clicked.");
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            saveFile = new SaveFileDialog();
            saveFile.Filter = "JPG(*.jpg)|*.jpg";
            if (saveFile.ShowDialog() == true)
            {
                //image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                this.bmpimage.Save(saveFile.FileName);
            }
        }

        

        

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == true )
            {
                //sets the diplay's source with the image that is selected.
                BitmapImage tempimg = new BitmapImage(new Uri(openFileDialog.FileName));
                imageDisplayed.Source = tempimg;
                bmpimage = BitmapImage2Bitmap(tempimg);
            }
        }


        private void CropButton_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void GrayscaleButton_Click(object sender, RoutedEventArgs e)
        {
            ImgEditLib.CommandDriver cmd = new ImgEditLib.CommandDriver(bmpimage, new ImgEditLib.GrayscaleCmd());
            bmpimage = cmd.returnImg;
            imageDisplayed.Source = Bitmap2BitmapImage(bmpimage);
            
        }


        private Bitmap BitmapImage2Bitmap(BitmapImage bitmapImage)
        {

            using(MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(bitmapImage));
                enc.Save(outStream);
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(outStream);
                return new Bitmap(bitmap);
            }
        }


        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);

        private BitmapSource Bitmap2BitmapImage(Bitmap bitmap)
        {


            BitmapSource i = Imaging.CreateBitmapSourceFromHBitmap(
                bitmap.GetHbitmap(),
                IntPtr.Zero,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());
            return i;
                
                




            //IntPtr hBitmap = bitmap.GetHbitmap();
            //BitmapImage retval;


            //try
            //{
            //    retval = (BitmapImage)Imaging.CreateBitmapSourceFromHBitmap(
            //        hBitmap,
            //        IntPtr.Zero,
            //        Int32Rect.Empty,
            //        BitmapSizeOptions.FromEmptyOptions());
            //}
            //finally
            //{
            //    DeleteObject(hBitmap);
            //}

            //return retval;

        }






    }
}
