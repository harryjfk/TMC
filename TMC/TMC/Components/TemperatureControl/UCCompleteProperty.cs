namespace TMC.Components.TemperatureControl
{
    public partial class UCCompleteProperty : DevExpress.XtraEditors.XtraUserControl
    {
        public UCCompleteProperty()
        {

            InitializeComponent();
            DragOver += InnerControl.UCPropertyTempControl_DragOver;
            DragDrop += InnerControl.UCPropertyTempControl_DragDrop;
            
            ucPropertyTempControl1.TempList.StartValue = 0;
            trackBarControl1_Properties_EditValueChanging(trackBarControl1, null);
        }
        public UCPropertyTempControl InnerControl{get { return ucPropertyTempControl1; }
        }
        public double TempInterna
        {
            get { return ((PropertyItemList)ucPropertyTempControl1.TempList).TemperaturaInterna; }
            set { trackBarControl1.EditValue = value;
                trackBarControl1_Properties_EditValueChanging(null, null);
            }
        }
        public double TempAmbiente
        {
            get { return ((PropertyItemList)ucPropertyTempControl1.TempList).TemperaturaAmbiente; }
            set { trackBarControl2.EditValue = value;
            trackBarControl2_Properties_EditValueChanging(null, null);
            }
        }

              private void trackBarControl1_Properties_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
              {
                  textEdit1.Properties.EditValueChanged -= textEdit1_Properties_EditValueChanged;
                  textEdit1.EditValue = trackBarControl1.EditValue;
                  ((PropertyItemList)ucPropertyTempControl1.TempList).TemperaturaInterna = (int)trackBarControl1.EditValue;
                  textEdit1.Properties.EditValueChanged += textEdit1_Properties_EditValueChanged;
                  
              }

              private void trackBarControl2_Properties_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
              {
                  textEdit2.Properties.EditValueChanged -= textEdit2_Properties_EditValueChanged;
                  textEdit2.EditValue = trackBarControl2.EditValue;
                  ((PropertyItemList)ucPropertyTempControl1.TempList).TemperaturaAmbiente = (int)trackBarControl2.EditValue;
                  textEdit2.Properties.EditValueChanged += textEdit2_Properties_EditValueChanged;
              }

              private void textEdit2_Properties_EditValueChanged(object sender, System.EventArgs e)
              {
                  trackBarControl2.EditValue = textEdit2.EditValue;
              }

              private void textEdit1_Properties_EditValueChanged(object sender, System.EventArgs e)
              {
                  trackBarControl1.EditValue = textEdit1.EditValue;
              }

            
    }
}
