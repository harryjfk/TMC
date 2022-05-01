using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TMC.Components.GraphControl
{
    public partial class PointEditItem : DevExpress.XtraEditors.XtraUserControl
    {
        public PointEditItem()
        {
            InitializeComponent();
        }
        public Point Point {get
        {
            var p = new Point(int.Parse(textEdit1.EditValue.ToString()), int.Parse(textEdit2.EditValue.ToString()));
       
            return p ;
        }set { 
            
            textEdit1.EditValue = value.X;
            textEdit2.EditValue = value.Y;
        }}

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (OnButtonClick!=null)
                OnButtonClick(this, e);
        }

        public object Data { get; set; }
       public event EventHandler OnChange;
        public event EventHandler OnButtonClick;
        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            if (OnChange != null)
                OnChange(this, e);
        }
    }
}
