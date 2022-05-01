using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TMC.Components.GraphControl
{

    public partial class UCImageController : DevExpress.XtraEditors.XtraUserControl
    {
        public UCImageController() 
        {
            InitializeComponent();
           
        
        }
        public void UpdateEdit()
        {
            pointEditItem1.OnChange -= spinEdit5_EditValueChanged;
            spinEdit4.Properties.EditValueChanged -= spinEdit5_EditValueChanged;
            spinEdit5.Properties.EditValueChanged -= spinEdit5_EditValueChanged;
            pointEditItem1.Point = Control.GraphObject.ImageController.Rectangle.Location;
            spinEdit4.EditValue = Control.GraphObject.ImageController.Rectangle.Height;
            if (spinEdit4.Properties.Maximum == 10)
                spinEdit4.Properties.Maximum = 2 * Control.GraphObject.ImageController.Rectangle.Height;
            spinEdit4.EditValue = Control.GraphObject.ImageController.Rectangle.Height;
            if (spinEdit5.Properties.Maximum == 10)
                spinEdit5.Properties.Maximum = 2 * Control.GraphObject.ImageController.Rectangle.Width;
            spinEdit5.EditValue = Control.GraphObject.ImageController.Rectangle.Width;
            spinEdit3.Value = (int)Control.GraphObject.ImageController.Rotation;

            pointEditItem1.OnChange += spinEdit5_EditValueChanged;
            spinEdit4.Properties.EditValueChanged += spinEdit5_EditValueChanged;
            spinEdit5.Properties.EditValueChanged += spinEdit5_EditValueChanged;
           Control.Refresh();
        }
      
        
        private void spinEdit5_EditValueChanged(object sender, EventArgs e)
        {
            Control.GraphObject.ImageController.Rotation = float.Parse(spinEdit3.EditValue.ToString());
            Control.GraphObject.ImageController.Rectangle = new Rectangle(pointEditItem1.Point, new Size(int.Parse(spinEdit5.EditValue.ToString()), int.Parse(spinEdit4.EditValue.ToString())));
          UpdateEdit();
        }


        private void ExecuteChange(object sender, EventArgs e)
        {
            //if (OnChangeImage != null)
            //    OnChangeImage(sender, e);
            //UpdateEdit();
        }
        
        //public event EventHandler OnChangeImage;
        //private ImageController _controller;
        //private UCGraphControl _Control;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
           {
               Control.GraphObject. ImageController.LoadFromFile(openFileDialog1.FileName);
           UpdateEdit();
           //8 Controller.LoadFromFile(@"C:\Users\Harry\Desktop\Sin título.jpg");
           // Control.Refresh();
           }
        }

        public UCGraphControl Control
        {
            get; set;
            /*set { _controller = value;
        UpdateEdit();
          //  SetMethod(true);
        } */ }

        
    }

    [Serializable]
    public class ImageController
    {
        public ImageController()
        {
            _rect = new Rectangle();
        }
        private void LoadCSV(string filename)
        {
        }

        private void LoadImage(string filename)
        {
            _bitmap = Image.FromFile(filename);
            Rectangle = new Rectangle(new Point(), _bitmap.Size);

            //_bitrectangle = new Rectangle(0, 0, _bitmap.Width, _bitmap.Height);

        }
        public void LoadFromFile(string filename)
        {
            Rotation = 0;
            if (filename.ToLower().IndexOf("csv") > 0)
                LoadCSV(filename);
            else
                LoadImage(filename);

        }
      
        private Image _bitmap;
 
        private Rectangle _rect;
        public Image Image { get { return _bitmap; } }
        public Rectangle Rectangle
        {
            get { return _rect; }
            set
            {
                _rect = value;
             
            }
        }
        private static Image RotateImage(Bitmap sourceImage, int angle)
        {
            //Open the source image and create the bitmap for the rotatated image
            // using (Bitmap sourceImage = new B(input))
            Bitmap rotateImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            //Set the resolution for the rotation image
            //      rotateImage.SetResolution(sourceImage.HorizontalResolution, sourceImage.VerticalResolution);
            //Create a graphics object
            using (Graphics gdi = Graphics.FromImage(rotateImage))
            {
                //Rotate the image
                gdi.TranslateTransform(0.0F, 0.0F);
                //      gdi.TranslateTransform((float)sourceImage.Width / 2, (float)sourceImage.Height / 2);
                gdi.RotateTransform(angle);
                //  gdi.TranslateTransform(-(float)sourceImage.Width / 2, -(float)sourceImage.Height / 2);
                gdi.DrawImage(sourceImage, new System.Drawing.Point(0, 0));
            }

            //Save to a file
            //  rotateImage.Save(@"C:\a.bmp");
            return rotateImage;

        }
        public void Draw(Graphics e)
        {
            if (Image != null)
            {

                //     Image.RotateFlip();
                //     var g = Graphics.FromImage(Image);

                //     g.TranslateTransform(0.0F, 0.0F);

                //     // Then to rotate, prepending rotation matrix.
                //     g.RotateTransform();
                //     g.Save();
                //     g.Flush();
                //Image.Save(@"C:\a.bmp");

                Bitmap s = new Bitmap(Image);


                e.DrawImage(RotateImage(s, (int)(Rotation)), Rectangle);
                //  e.RotateTransform(50);
            }
        }

        public float Rotation { get; set; }
    }

}
