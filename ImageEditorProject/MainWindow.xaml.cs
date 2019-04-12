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
        private System.Drawing.Image image;
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
                image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                this.image.Save(saveFile.FileName);
            }
        }

        

        

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == true )
            {
                //makes a new temporary bitmap image so we can scale down the display
                BitmapImage temp = new BitmapImage(new Uri(openFileDialog.FileName));
                
                //scale down the display's height and width so the image doesnt look distorted
                imageDisplayed.Height = temp.Height;
                imageDisplayed.Width = temp.Width;
                //sets the diplay's source with the image that is selected.
                imageDisplayed.Source = temp;
            }
        }


        private void CropButton_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void GrayscaleButton_Click(object sender, RoutedEventArgs e)
        {
            
            ImgEditLib.Command cmd = new ImgEditLib.GrayscaleCommand();
            image = System.Drawing.Image.FromFile(openFileDialog.FileName);
            image = cmd.Execute(new Bitmap(image), openFileDialog.FileName);
            MessageBox.Show(openFileDialog.FileName);
            
            BitmapImage bitmapImage = new BitmapImage(new Uri(openFileDialog.FileName));
            imageDisplayed.Source = bitmapImage;
        }
    }
}
