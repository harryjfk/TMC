using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NCalc;
using TMC.Components;

namespace TMC.MCC.Tareas
{
    public partial class FrmSimulate : XtraForm
    {
        public FrmSimulate()
        {
            InitializeComponent();
        }
        private Dictionary<String, decimal> db = new Dictionary<string, decimal>();

        private void wizardPage1_Click(object sender, EventArgs e)
        {

        }

        private void wizardControl1_SelectedPageChanged(object sender, DevExpress.XtraWizard.WizardPageChangedEventArgs e)
        {
            //if (e.Page == VEPage)
            //   groupControl3_Click(null,null);
            //if (e.Page == wizardPage6)
            //    groupControl9_Click(null,null);
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            //Calculated
        }
        private void AddToDictonary(string key, decimal value)
        {
            if (db.ContainsKey(key))
                db.Remove(key);
            db.Add(key, value);}
        private void wizardControl1_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            if (e.Page == wizardPage1)
            {
                //if (!Maquina.EsMultp_3(int.Parse(textEdit1.Text)))
                //{
                //    MessageBox.Show("Debe ser Multiplo de 3");
                //    e.Handled = true;
                //    //e. = wizardPage1;
                //}
            }

            if (e.Page == LOPage)
            {
                if (checkEdit_Calc_Anterior.Checked)
                {
                    var tr = GetByValue(gridLookUpEdit_Tecnologia.EditValue);
                    if (tr != null)
                        AddToDictonary("LO",
                                       decimal.Parse(tr["lo"].ToString().Substring(0, tr["lo"].ToString().IndexOf(' '))));
                }
                else

                    AddToDictonary("LO",
                                   decimal.Parse(
                                       new Expression("((3.14*" + textEdit_Radio.Text + "*90)/180)+" +
                                                      textEdit_Larg_Maq.Text).Evaluate().ToString()));
            }
            else
                if (e.Page == VCPage)
            {
                if (checkEdit_Cal_Anterior2.Checked)
                {
                    var tr = GetByValue(gridLookUpEdit_Tecnol_VC.EditValue);
                    if (tr != null)
                        AddToDictonary("VC",
                                       decimal.Parse(tr["vc"].ToString().Substring(0, tr["vc"].ToString().IndexOf(' '))));
                }
                else

                    AddToDictonary("VC",
                                   decimal.Parse(
                                       new Expression("((3.14*Pow(" + textEdit_Diam_Boq_Dist.Text + ",2))/4)*(Sqrt(2*35316*" + textEdit_Alt_Acero.Text + "))*7600").Evaluate().ToString()));
            }
                else
                     
                    if (e.Page == VEPage)
            {
              
                    var tr = GetByValue(gridLookUpEdi_Velc_Extr.EditValue);
                    if (tr != null)
                        AddToDictonary("VE",
                                       decimal.Parse(tr["ve"].ToString().Substring(0, tr["ve"].ToString().IndexOf(' '))));

                    else
                    {
                        AddToDictonary("VE",
                                       decimal.Parse(
                                           new Expression(double.Parse(Maquina.GetParametroValue("fAM")) +
                                           "/" +
                                           (Decimal.Round((Decimal) (Palanquilla.GetArea()/1000000), 4)).ToString().Replace(',','.')).Evaluate().ToString()));
                    }

            } if (e.Page == VPPage)
            {
                if (checkEdit_Cal_Anterior3.Checked)
                {
                    var tr = GetByValue(gridLookUpEdit_Velc_Prod.EditValue);
                    if (tr != null)
                        AddToDictonary("VP",
                                       decimal.Parse(tr["vp"].ToString().Substring(0, tr["vp"].ToString().IndexOf(' '))));
                }
                else 

                    AddToDictonary("VP",
                                   decimal.Parse(
                                       new Expression(textEdit_Cant_AC_C.Text +"/("+ textEdit_Num_L_C.Text + "*" +  db["VC"]+")").Evaluate().ToString()));
            }


            if (e.Page == SOLDFPage)
            {
                if (checkEdit_LMAC_1.Checked)
                {
                    var tr = GetByValue(gridLookUpEdit_LMAC.EditValue);
                    if (tr != null)
                        AddToDictonary("LMCAL",
                                       decimal.Parse(tr["lmcal"].ToString().Substring(0, tr["lmcal"].ToString().IndexOf(' '))));
                }
                else
                     AddToDictonary("LMCAL",
                                   decimal.Parse(
                                       new Expression("("+ Palanquilla.GetTamanho() + "/2*28.5)² * " + db["VE"]+ ")").Evaluate().ToString()));
            }




            if (e.Page == TIPACPage)
            {
                if (checkEdit_Cal_Anterior4.Checked)
                {
                    var tr = GetByValue(gridLookUpEdit_TPAC.EditValue);
                    if (tr != null)
                        AddToDictonary("TIPAC",
                                       decimal.Parse(tr["tipac"].ToString().Substring(0, tr["tipac"].ToString().IndexOf(' '))));
                }
                else

                    AddToDictonary("TIPAC",
                                   decimal.Parse(
                                       new Expression(textEdit_Cant_AC_C.Text + "/(" + textEdit_Num_L_C.Text + "*" + db["VP"] + ")").Evaluate().ToString()));
            }




            if (e.Page == TIPADPage)
            {
                if (checkEdit_Cal_Anterior4.Checked)
                {
                    var tr = GetByValue(gridLookUpEdit_TPAD.EditValue);
                    if (tr != null)
                        AddToDictonary("TIPAD",
                                       decimal.Parse(tr["tipad"].ToString().Substring(0, tr["tipad"].ToString().IndexOf(' '))));
                }
                else

                    AddToDictonary("TIPAD",
                                   decimal.Parse(
                                       new Expression(textEdit_Cant_AC_D.Text + "/(" + textEdit_Num_L_D.Text + "*" + db["VP"] + ")").Evaluate().ToString()));
            }



            if (e.Page == CTTPage)
            {
                if (checkEdit2.Checked)
                {
                    var tr = GetByValue(gridLookUpEdit4.EditValue);
                    if (tr != null)
                        AddToDictonary("CTT",
                                       decimal.Parse(tr["ctt"].ToString().Substring(0, tr["ctt"].ToString().IndexOf(' '))));
                }
                else
                {
                    var Valores = new Dictionary<string, double>();
                    Valores.Add("y", double.Parse(textEdit_Esp_Mold_CTT.Text));
                    Valores.Add("z", double.Parse(textEdit_GAP_CTT.Text));
                    Valores.Add("DT", double.Parse(textEdit_DT_CTT.Text));
                    var CTT = Maquina.CalorTotalTransferido(Palanquilla, 1, Valores);
                    var Datos = new Dictionary<string, string>();


                    Datos.Add("p1", (Palanquilla.Area_Intercambio(1)*Maquina.GetValor(Valores, "DT")/60).ToString());
                    Datos.Add("p2",
                              ((Maquina.GetValor(Valores, "x")/Maquina.GetValor(Valores, "Kx")) +
                               (Maquina.GetValor(Valores, "y")/Maquina.GetValor(Valores, "Ky")) +
                               (Maquina.GetValor(Valores, "z")/Maquina.GetValor(Valores, "Kz"))).ToString().Substring(
                                   0, 10));
                   
                    AddToDictonary("CTT",
                                   (decimal.Parse( Evaluate(Datos, "(p1/p2)"))));


                }
            }



            if (e.Page == CMAEPage)
            {
                if (checkEdit_CAME_1.Checked)
                {
                    var tr = GetByValue(gridLookUpEdit_CMAE.EditValue);
                    if (tr != null)
                        AddToDictonary("CMAE",
                                       decimal.Parse(tr["cmae"].ToString().Substring(0, tr["cmae"].ToString().IndexOf(' '))));
                }
                else

                    AddToDictonary("CMAE",
                                   decimal.Parse(
                                       new Expression(db["CTT"] + "/(" + textEdit_Calor_Esp_Agu.Text + "*" + textEdit2.Text + ")").Evaluate().ToString()));
            }




            if (e.Page == VMAPage)
            {
                if (checkEdit_VMA_1.Checked)
                {
                    var tr = GetByValue(gridLookUpEdit_VMA.EditValue);
                    if (tr != null)
                        AddToDictonary("VMA",
                                       decimal.Parse(tr["vma"].ToString().Substring(0, tr["vma"].ToString().IndexOf(' '))));
                }
                else

                    AddToDictonary("VMA",
                                   decimal.Parse(
                                       new Expression("(" + textEdit_Caudal_Agua.Text + "*1000)/(" + gridLookUpEdit_Area_Circulacion.GetSelectedDataRow()+ "*60)").Evaluate().ToString()));
            }


            if (e.Page == EPPaje)
            {
                if (checkEdit_EP_1.Checked)
                {
                    var tr = GetByValue(gridLookUpEdit_EP.EditValue);
                    if (tr != null)
                        AddToDictonary("EP",
                                       decimal.Parse(tr["ep"].ToString().Substring(0, tr["ep"].ToString().IndexOf(' '))));
                }
                else
                {
                    double q = double.Parse(Maquina.GetParametroValue("pAliq")) * double.Parse(Maquina.GetParametroValue("Ce")) * double.Parse(Maquina.GetParametroValue("DTs")) + double.Parse(Maquina.GetParametroValue("oS"));

                    AddToDictonary("EP",
                                   decimal.Parse(
                                       new Expression("(" + db["CTT"] + "/1)/(4+" + (Decimal.Round((Decimal)(Palanquilla.GetArea() / 1000000), 4)) + q + db["VE"]).Evaluate().ToString()));
                }
            }




            if (e.Page == OMPage)
            {
                if (checkEdit_OM_1.Checked)
                {
                    var tr = GetByValue(gridLookUpEdit_OM_1.EditValue);
                    if (tr != null)
                        AddToDictonary("OM",
                                       decimal.Parse(tr["om"].ToString().Substring(0, tr["om"].ToString().IndexOf(' '))));
                }
                else
                {

                    AddToDictonary("OM",
                                   decimal.Parse(
                                       new Expression("(" + db["VE"] + "*650)/" + textEdit_OM.Text).Evaluate().ToString()));
                }
            }


            if (e.Page == TSPage)
            {
                if (checkEdit_TS_1.Checked)
                {
                    var tr = GetByValue(gridLookUpEdit_TS.EditValue);
                    if (tr != null)
                        AddToDictonary("TS",
                                       decimal.Parse(tr["ts"].ToString().Substring(0, tr["ts"].ToString().IndexOf(' '))));
                }
                else
                {
                    double arcocos = Math.Cosh(double.Parse(db["VE"].ToString()) / (Math.PI * double.Parse(db["om"].ToString()) * double.Parse(textEdit_TS_2.Text)));
                    AddToDictonary("TS",
                                   decimal.Parse(
                                       new Expression("((1/(3.1416*" + db["om"] + "))*" + arcocos + "* 60)").Evaluate().ToString()));
                }
            }


            if (e.Page == ESPage)
            {
                if (checkEdit_ES_1.Checked)
                {
                    var tr = GetByValue(gridLookUpEdit_ES.EditValue);
                    if (tr != null)
                        AddToDictonary("ESZ1",
                                       decimal.Parse(tr["esz1"].ToString().Substring(0, tr["esz1"].ToString().IndexOf(' '))));
                        AddToDictonary("ESZ2",
                                      decimal.Parse(tr["esz2"].ToString().Substring(0, tr["esz2"].ToString().IndexOf(' '))));
                        AddToDictonary("ESZ3",
                                      decimal.Parse(tr["esz3"].ToString().Substring(0, tr["esz3"].ToString().IndexOf(' '))));
                }
                else
                {
                    AddToDictonary("ESZ1",
                                   decimal.Parse(
                                       new Expression(comboBoxEdit1.EditValue+"*(130* ("+ comboBoxEdit4.EditValue +" +(0.007 * " +comboBoxEdit5.EditValue +")) * "+ db["VE"]+")/100").Evaluate().ToString()));
                    AddToDictonary("ESZ2",
                                 decimal.Parse(
                                     new Expression(comboBoxEdit2.EditValue + "*(130* (" + comboBoxEdit4.EditValue + " +(0.007 * " + comboBoxEdit5.EditValue + ")) * " + db["VE"] + ")/100").Evaluate().ToString()));
                    AddToDictonary("ESZ3",
                                 decimal.Parse(
                                     new Expression(labelControl6.Text + "*(130* (" + comboBoxEdit4.EditValue + " +(0.007 * " + comboBoxEdit5.EditValue + ")) * " + db["VE"] + ")/100").Evaluate().ToString()));
                }
            }



            if (e.Page == ALPage)
            {
                if (checkEdit_AL_1.Checked)
                {
                    var tr = GetByValue(gridLookUpEdit_AL.EditValue);
                    if (tr != null)
                        AddToDictonary("AL",
                                       decimal.Parse(tr["al"].ToString().Substring(0, tr["al"].ToString().IndexOf(' '))));
                }
                else
                {
                    AddToDictonary("AL",
                                   decimal.Parse(
                                       new Expression(textEdit_AL_1.Text + "*" + textEdit_AL_2.Text).Evaluate().ToString()));
                }
            }

        }

        /// <summary>
        /// SE DECLARAN LAS INSTANCIAS PARA TRABAJAR DURANTE EL LA CRECION DE LA TECNOLOGIA.
        /// </summary>
        
        public DSMCC.T_MaquinaRow Maquina
        {
            get { return (DSMCC.T_MaquinaRow)((DataRowView)tMaquinaBindingSource.Current).Row; }
        }

        public DSMCC.T_PalanquillaRow Palanquilla
        {
            get { return (DSMCC.T_PalanquillaRow)((DataRowView)fKTPalanquillaTMaquinaBindingSource.Current).Row; }
        }

        public DSMCC.T_AceroRow Acero
        {
            get { return (DSMCC.T_AceroRow)((DataRowView)tMarcaBindingSource.Current).Row; }
        }

        private void gridLookUpEdit2_Properties_EditValueChanged(object sender, EventArgs e)
        {

            ((BindingSource)((GridLookUpEdit)sender).Properties.DataSource).Position = ((GridLookUpEdit)sender).Properties.GetIndexByKeyValue(((GridLookUpEdit)sender).EditValue);

        }

        private void FrmSimulate_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Tecnologia' Puede moverla o quitarla según sea necesario.
            this.t_TecnologiaTableAdapter.Fill(this.dSDatos.T_Tecnologia);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Marca' Puede moverla o quitarla según sea necesario.
            this.t_MarcaTableAdapter.Fill(this.dSDatos.T_Acero);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Palanquilla' Puede moverla o quitarla según sea necesario.
            this.t_PalanquillaTableAdapter.Fill(this.dSDatos.T_Palanquilla);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Maquina' Puede moverla o quitarla según sea necesario.
            this.t_MaquinaTableAdapter.Fill(this.dSDatos.T_Maquina);
            t_MaquinaParametroTableAdapter1.Fill(dSDatos.T_ParametroValor);
            t_AceroNormaTableAdapter1.Fill(dSDatos.T_AceroNorma);
            t_ParametrosTableAdapter1.Fill(dSDatos.T_Parametros);
            t_Circulacion_AMTableAdapter1.Fill(dSDatos.T_Circulacion_AM);
            t_ParametroValorTableAdapter1.FillBy(dSDatos.T_ParametroValor, false);
            checkEdit_Calc_Anterior_Click_1(checkEdit_Calc_Anterior, null);
            checkEdit_Cal_Anterior2_Click(checkEdit_Cal_Anterior2, null);
            checkEdit_Cal_Anterior3_Click(checkEdit_Cal_Anterior3, null);
            checkEdit_Cal_Anterior4_Click(checkEdit_Cal_Anterior4, null);
            checkEdit__Calc_Anterior5_Click(checkEdit__Calc_Anterior5, null);
            checkEdit2_Click(checkEdit2, null);
            checkEdit5_Click(checkEdit_CAME_1, null);
            checkEdit_VMA_1_Click(checkEdit_VMA_1, null);
            checkEdit_EP_1_Click(checkEdit_EP_1, null);
            checkEdit_OM_1_Click(checkEdit_OM_1, null);
            checkEdit_TS_1_Click(checkEdit_TS_1, null);
            checkEdit_DMO_1_Click(checkEdit_DMO_1, null);
            checkEdit_AL_1_Click(checkEdit_AL_1, null);
            dSDatos.T_Acero.FillName(Properties.Settings.Default.Norma);

        }




        private String Evaluate(Dictionary<String, String> t,String str )
        {
          return  new Ecuation(str, "", t).RightSide.Parameters.AsDouble().ToString();

        }
        private void textEdit_Radio_EditValueChanged_1(object sender, EventArgs e)
        {
            var Datos = new Dictionary<string, string>();
            bool byparam = !(sender is GridLookUpEdit);

            if (byparam)
            {
                Datos.Add("p1", textEdit_Radio.Text);
                Datos.Add("p3", textEdit_Larg_Maq.Text);
                Datos.Add("p2", Evaluate(Datos,"(3.14*p1*90)/180") );
                Datos.Add("p4", Evaluate(Datos,"p2+p3" ));
          }
            else
            {
                var tr = GetByValue(gridLookUpEdit_Tecnologia.EditValue);
                if (tr != null)
                    Datos.Add("p1", tr.GetValor("lo").ToString());
            }

            Maquina.ShowFormulates(Datos, FCLargoMetal, TLE.LargoMetalurgico, byparam);
        }
        public DSMCC.T_TecnologiaRow GetByValue(object value)
        {
            var ti = tTecnologiaBindingSource.Find("idtecnologia", value);
            if(ti!=-1)
                return (DSMCC.T_TecnologiaRow)((DataRowView)tTecnologiaBindingSource[ti]).Row;
            return null;
        }

        private void textEdit_Diam_Boq_Dist_EditValueChanged(object sender, EventArgs e)
        {


           var Datos = new Dictionary<string, string>();
            bool byparam = !(sender is GridLookUpEdit);

            if (byparam)
            {
                Datos.Add("p1", textEdit_Diam_Boq_Dist.Text);
                Datos.Add("p2", textEdit_Alt_Acero.Text);
                Datos.Add("p3", "(3.14*(" + Evaluate(Datos, "p1^2") + "))/4");
                Datos.Add("p4", Evaluate(Datos, "p3"));
                Datos.Add("p5", Maquina.NoteCient(Evaluate(Datos, "p3")));
                Datos.Add("p6",Evaluate(Datos, "(√(2*35316*p2))*7600"));
                Datos.Add("p7", Maquina.NoteCient(Evaluate(Datos, "p6")));
                Datos.Add("p8", Evaluate(Datos, "p6").ToString());
                if (Evaluate(Datos, "p4*p8").Length > 7)
                {
                    Datos.Add("p9", Evaluate(Datos, "p4*p8").Substring(0, 7));
                    Datos.Add("p10", Maquina.NoteCient(Evaluate(Datos, "p4*p8")));
                }
                else
                    Datos.Add("p10", Evaluate(Datos, "0"));
            }
            else
            {
                var tr = GetByValue(gridLookUpEdit_Tecnologia.EditValue);
                if (tr != null)
                    Datos.Add("p1", tr["vc"].ToString());
            }

            Maquina.ShowFormulates(Datos, FCVelocidadColada, TLE.VelocidadColada, byparam);


        }



        private void textEdit_Dens_Ace_Sol_EditValueChanged(object sender, EventArgs e)
        {
            var Datos = new Dictionary<string, string>();
          bool byparam = !(sender is GridLookUpEdit);

            if (byparam)
            {
                Datos.Add("p1", (Decimal.Round((Decimal)(Palanquilla.GetArea() / 1000000), 4)).ToString());
                Datos.Add("p2", db["VE"].ToString());
                Datos.Add("p3", textEdit_Dens_Ace_Sol.Text);
                Datos.Add("p4", textEdit_lineas.Text);
                Datos.Add("p5", Evaluate(Datos, "(p1*p2*p3*p4"));
            }
            else
            {
                var tr = GetByValue(gridLookUpEdit_Tecnologia.EditValue);
                if (tr != null)
                    Datos.Add("p1", tr["vp"].ToString());
            }

            Maquina.ShowFormulates(Datos, FCVelocidadProduccion, TLE.VelocidadProduccion, byparam);
        }



        private void textEdit_Cant_AC_C_EditValueChanged(object sender, EventArgs e)
        {
          
            var Datos = new Dictionary<string, string>();
            bool byparam = !(sender is GridLookUpEdit);

            if (byparam)
            {
                Datos.Add("p1", textEdit_Cant_AC_C.Text);
                Datos.Add("p2", textEdit_Num_L_C.Text);
                Datos.Add("p3", db["VP"].ToString());
                Datos.Add("p4", Evaluate(Datos, "(p1/(p2*p3)"));


            }
            else
            {
                var tr = GetByValue(gridLookUpEdit_Tecnologia.EditValue);
                if (tr != null)
                    Datos.Add("p1", tr["tipac"].ToString());
            }

            Maquina.ShowFormulates(Datos, FCTiempoPAC, TLE.TiempPermancAC, byparam);
        }

        private void textEdit_Cant_AC_D_EditValueChanged(object sender, EventArgs e)
        {
            var Datos = new Dictionary<string, string>();
            bool byparam = !(sender is GridLookUpEdit);

            if (byparam)
            {
                Datos.Add("p1", textEdit_Cant_AC_D.Text);
                Datos.Add("p2", textEdit_Num_L_D.Text);
                Datos.Add("p3", db["VP"].ToString());
                Datos.Add("p4", Evaluate(Datos, "(p1/(p2*p3)"));
            }
            else
            {
                var tr = GetByValue(gridLookUpEdit_Tecnologia.EditValue);
                if (tr != null)
                    Datos.Add("p1", tr["tipad"].ToString());
            }

            Maquina.ShowFormulates(Datos, FCTiempoRAD, TLE.TiempPermancAD, byparam);
        }
        

        private void wizardControl1_Click(object sender, EventArgs e)
        {

        }





        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {
            var Datos = new Dictionary<string, string>();
            bool byparam = !(sender is GridLookUpEdit);
            var Valores = new Dictionary<string, double>();
            Valores.Add("y", double.Parse(textEdit_Esp_Mold_CTT.Text));
            Valores.Add("z", double.Parse(textEdit_GAP_CTT.Text));
            Valores.Add("DT", double.Parse(textEdit_DT_CTT.Text));
            


            if (byparam)
            {
                Datos.Add("p1", (Palanquilla.Area_Intercambio(1) * Maquina.GetValor(Valores, "DT") / 60).ToString());
                Datos.Add("p2",
                          ((Maquina.GetValor(Valores, "x") / Maquina.GetValor(Valores, "Kx")) +
                           (Maquina.GetValor(Valores, "y") / Maquina.GetValor(Valores, "Ky")) +
                           (Maquina.GetValor(Valores, "z") / Maquina.GetValor(Valores, "Kz"))).ToString().Substring(0, 10));
                if (Evaluate(Datos, "(p1/p2)").Length > 7)
                    Datos.Add("p3", Evaluate(Datos, "(p1/p2)").Substring(0, 8));
            }
            else
            {
                var tr = GetByValue(gridLookUpEdit_Tecnologia.EditValue);
                if (tr != null)
                    Datos.Add("p1", tr["ctt"].ToString());
            }

            Maquina.ShowFormulates(Datos, FCCalorTotalTransferido, TLE.CTT, byparam);
        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {
            var Datos = new Dictionary<string, string>();
            bool byparam = !(sender is GridLookUpEdit);

            if (byparam)
            {
                Datos.Add("p1", db["CTT"].ToString());
                Datos.Add("p2", textEdit_Calor_Esp_Agu.Text);
                Datos.Add("p3", textEdit2.Text);
                Datos.Add("p4", Evaluate(Datos, "p1/(p2*p3)"));

            }
            else
            {
                var tr = GetByValue(gridLookUpEdit_Tecnologia.EditValue);
                if (tr != null)
                    Datos.Add("p1", tr["cmae"].ToString());
            }

            Maquina.ShowFormulates(Datos, FCCant_Max_AE, TLE.CantAgua, byparam);
        }


        private void gridLookUpEdit6_Properties_EditValueChanged(object sender, EventArgs e)
        {
            var Datos = new Dictionary<string, string>();
            bool byparam = !(sender is GridLookUpEdit);

            if (byparam)
            {
                Datos.Add("p1", textEdit_Caudal_Agua.Text);
                Datos.Add("p2", gridLookUpEdit_Area_Circulacion.GetSelectedDataRow().ToString());
                Datos.Add("p3", Evaluate(Datos, "(p1*1000)/(p2*60)"));

            }
            else
            {
                var tr = GetByValue(gridLookUpEdit_Tecnologia.EditValue);
                if (tr != null)
                    Datos.Add("p1", tr["vma"].ToString());
            }

            Maquina.ShowFormulates(Datos, FCVMA, TLE.VelocidadAgua, byparam);
        }

        private void checkEdit_Calc_Pers_Click_1(object sender, EventArgs e)
        {
            labelContr_Tecnologias.Enabled = false;
            gridLookUpEdit_Tecnologia.Enabled = false;


            labelContr_Radio.Enabled = true;
            labelContr_Larg_Maq.Enabled = true;
            textEdit_Larg_Maq.Enabled = true;
            textEdit_Radio.Enabled = true;
        }

        private void checkEdit_Calc_Anterior_Click_1(object sender, EventArgs e)
        {
            labelContr_Tecnologias.Enabled = true;
            gridLookUpEdit_Tecnologia.Enabled = true;


            labelContr_Radio.Enabled = false;
            labelContr_Larg_Maq.Enabled = false;
            textEdit_Larg_Maq.Enabled = false;
            textEdit_Radio.Enabled = false;
        }

        private void checkEdit_Cal_Anterior2_Click(object sender, EventArgs e)
        {
            labelContr_Tecnologia2.Enabled = true;
            gridLookUpEdit_Tecnol_VC.Enabled = true;


            labelContr_AA.Enabled = false;
            labelContr_DBD.Enabled = false;
            textEdit_Alt_Acero.Enabled = false;
            textEdit_Diam_Boq_Dist.Enabled = false;
        }

        private void checkEdit_Calc_Pers2_Click(object sender, EventArgs e)
        {
            labelContr_Tecnologia2.Enabled = false;
            gridLookUpEdit_Tecnol_VC.Enabled = false;


            labelContr_AA.Enabled = true;
            labelContr_DBD.Enabled = true;
            textEdit_Alt_Acero.Enabled = true;
            textEdit_Diam_Boq_Dist.Enabled = true;
        }

        private void checkEdit_Cal_Anterior3_Click(object sender, EventArgs e)
        {
            labelContr_Tecnologia3.Enabled = true;
            gridLookUpEdit_Velc_Prod.Enabled = true;


            labelControl_DAS.Enabled = false;
            labelControl_NL.Enabled = false;
            textEdit_Dens_Ace_Sol.Enabled = false;
            textEdit_lineas.Enabled = false;
        }

        private void checkEdit_Calc_Pers3_Click(object sender, EventArgs e)
        {
            labelContr_Tecnologia3.Enabled = false;
            gridLookUpEdit_Velc_Prod.Enabled = false;


            labelControl_DAS.Enabled = true;
            labelControl_NL.Enabled = true;
            textEdit_Dens_Ace_Sol.Enabled = true;
            textEdit_lineas.Enabled = true;
        }

        private void checkEdit_Cal_Anterior4_Click(object sender, EventArgs e)
        {
            labelContr_Tecnologia4.Enabled = sender ==checkEdit_Cal_Anterior4;
            gridLookUpEdit_TPAC.Enabled = sender == checkEdit_Cal_Anterior4;


            labelContr_CAC.Enabled = !gridLookUpEdit_TPAC.Enabled;
            labelContr_NLC.Enabled = labelContr_CAC.Enabled;
            textEdit_Num_L_C.Enabled = labelContr_CAC.Enabled;
            textEdit_Cant_AC_C.Enabled = labelContr_CAC.Enabled;
        }

        private void checkEdit__Calc_Anterior5_Click(object sender, EventArgs e)
        {
            labelContr_Tecnologia5.Enabled = true;
            gridLookUpEdit_TPAD.Enabled = true;


            labelContr_CAD.Enabled = false;
            labelContr_NLC2.Enabled = false;
            textEdit_Num_L_D.Enabled = false;
            textEdit_Cant_AC_D.Enabled = false;
        }

        private void checkEdit_Calc_Pers5_Click(object sender, EventArgs e)
        {
            labelContr_Tecnologia5.Enabled = false;
            gridLookUpEdit_TPAD.Enabled = false;


            labelContr_CAD.Enabled = true;
            labelContr_NLC2.Enabled = true;
            textEdit_Num_L_D.Enabled = true;
            textEdit_Cant_AC_D.Enabled = true;
        }

        private void checkEdit2_Click(object sender, EventArgs e)
        {
            labelControl54.Enabled = sender == checkEdit2;
            gridLookUpEdit4.Enabled = sender == checkEdit2;


            textEdit_Esp_Mold_CTT.Enabled = !gridLookUpEdit4.Enabled;
            textEdit_DT_CTT.Enabled = textEdit_Esp_Mold_CTT.Enabled;
            textEdit_GAP_CTT.Enabled = textEdit_Esp_Mold_CTT.Enabled;

            labelControl52.Enabled = textEdit_Esp_Mold_CTT.Enabled;
            labelControl53.Enabled = textEdit_Esp_Mold_CTT.Enabled;
            labelControl56.Enabled = textEdit_Esp_Mold_CTT.Enabled;


        }

        private void checkEdit5_Click(object sender, EventArgs e)
        {
            labelControl65.Enabled = sender == checkEdit_CAME_1;
            gridLookUpEdit_CMAE.Enabled = sender == checkEdit_CAME_1;


            textEdit_Calor_Esp_Agu.Enabled = !gridLookUpEdit_CMAE.Enabled;
            textEdit2.Enabled = textEdit_Calor_Esp_Agu.Enabled;

            labelControl64.Enabled = textEdit_Calor_Esp_Agu.Enabled;
            labelControl2.Enabled = textEdit_Calor_Esp_Agu.Enabled;
            
        }

        private void checkEdit_VMA_1_Click(object sender, EventArgs e)
        {
            labelControl_Tecnologia_VMA.Enabled = sender == checkEdit_VMA_1;
            gridLookUpEdit_VMA.Enabled = sender == checkEdit_VMA_1;


            textEdit_Caudal_Agua.Enabled = !gridLookUpEdit_VMA.Enabled;
            gridLookUpEdit_Area_Circulacion.Enabled = textEdit_Caudal_Agua.Enabled;

            labelControl_VMA_CA.Enabled = textEdit_Caudal_Agua.Enabled;
            labelControl_Area_Circulacion.Enabled = textEdit_Caudal_Agua.Enabled;
        }

        private void textEdit_Caudal_Agua_EditValueChanged(object sender, EventArgs e)
        {
         /*   var Datos = new Dictionary<string, string>();
            bool byparam = !(sender != gridLookUpEdit_Area_Circulacion);

            if (byparam)
            {
                Datos.Add("p1", textEdit_Caudal_Agua.Text);
                Datos.Add("p2", gridLookUpEdit_Area_Circulacion.EditValue.ToString());
                Datos.Add("p3", MathCalculator.Calculate(Datos, "(p1*1000)/(p2*60)").ToString());

            }
            else
            {
                var tr = GetByValue(gridLookUpEdit_Tecnologia.EditValue);
                if (tr != null)
                    Datos.Add("p1", tr["vma"].ToString());
            }

            Maquina.ShowFormulates(Datos, FCVMA, TLE.VelocidadAgua, byparam);
     */   }

        

        private void gridLookUpEdi_Velc_Extr_Properties_EditValueChange(object sender, EventArgs e)
        {
            var Datos = new Dictionary<string, string>();
            bool byparam = (sender == checkEdit_VE_2);

            if (byparam)
            {
                Datos.Add("p1", double.Parse(Maquina.GetParametroValue("fAM")).ToString());
                Datos.Add("p2", (Decimal.Round((Decimal)(Palanquilla.GetArea() / 1000000), 4)).ToString());
                Datos.Add("p3", Evaluate(Datos, "(p1/p2)"));
                
            }
            else
            {
                var tr = GetByValue(gridLookUpEdi_Velc_Extr.EditValue);
                if (tr != null)
                    Datos.Add("p1", tr["ve"].ToString());
                
            }

            Maquina.ShowFormulates(Datos, FCVelocidadExtraccion, TLE.VelocidadExtraccion, byparam);
        }

        
        

        private void checkEdit_VE_2_Click(object sender, EventArgs e)
        {
            labelControl_VE_1.Enabled = sender == checkEdit_VE_1;
            gridLookUpEdi_Velc_Extr.Enabled = sender == checkEdit_VE_1;
        }

        private void checkEdit_VE_1_Click(object sender, EventArgs e)
        {
            labelControl_VE_1.Enabled = sender == checkEdit_VE_1;
            gridLookUpEdi_Velc_Extr.Enabled = sender == checkEdit_VE_1;
        }

        private void checkEdit_SOLDF_1_Click(object sender, EventArgs e)
        {
            labelControl_LMAC_1.Enabled = sender == checkEdit_LMAC_1;
            gridLookUpEdit_LMAC.Enabled = sender == checkEdit_LMAC_1;
        }

        private void gridLookUpEdit_LMAC_Properties_EditValueChanged(object sender, EventArgs e)
        {
            var Datos = new Dictionary<string, string>();
            bool byparam = (checkEdit_LMAC_2.Checked == true);
            if (byparam)
            {
                Datos.Add("p1", Palanquilla.GetTamanho().ToString());
                Datos.Add("p2", db["VE"].ToString());
                Datos.Add("p3", Evaluate(Datos, "((p1/(2*28.5))^2)*p2"));
            }
            else
            {
                var tr = GetByValue(gridLookUpEdit_LMAC.EditValue);
                if (tr != null)
                    Datos.Add("p1", tr["lmcal"].ToString());
            }


            Maquina.ShowFormulates(Datos, FCLongitud_M_calculada, TLE.Solidificacion, byparam);
        }

        private void checkEdit_LMAC_2_Click(object sender, EventArgs e)
        {
            labelControl_LMAC_1.Enabled = sender == checkEdit_LMAC_1;
            gridLookUpEdit_LMAC.Enabled = sender == checkEdit_LMAC_1;
        }

        private void gridLookUpEdit_EP_Properties_EditValueChanged(object sender, EventArgs e)
        {
            var Datos = new Dictionary<string, string>();
            bool byparam = (sender == checkEdit_EP_2);

            if (byparam)
            {
                double q = double.Parse(Maquina.GetParametroValue("pAliq")) *
                           double.Parse(Maquina.GetParametroValue("Ce")) * double.Parse(Maquina.GetParametroValue("DTs")) +
                           double.Parse(Maquina.GetParametroValue("oS"));

                Datos.Add("p1", db["CTT"].ToString());
                Datos.Add("p2", (Decimal.Round((Decimal)(Palanquilla.GetArea() / 1000000), 4)).ToString());
                Datos.Add("p3", q.ToString());
                Datos.Add("p4", db["VE"].ToString());
                Datos.Add("p5", Evaluate(Datos, "(p1/1)/(4+p2+p3+p4)"));
            }
            else
            {
                var tr = GetByValue(gridLookUpEdit_EP.EditValue);
                if (tr != null)
                    Datos.Add("p1", tr["ep"].ToString());
            }

            Maquina.ShowFormulates(Datos, FCEP, TLE.EspesorPiel, byparam);
        }

        private void checkEdit_EP_1_Click(object sender, EventArgs e)
        {
            labelControl_EP_1.Enabled = sender == checkEdit_EP_1;
            gridLookUpEdit_EP.Enabled = sender == checkEdit_EP_1;
        }

        private void checkEdit_EP_2_Click(object sender, EventArgs e)
        {
            labelControl_EP_1.Enabled = sender == checkEdit_EP_1;
            gridLookUpEdit_EP.Enabled = sender == checkEdit_EP_1;
        }

        private void gridLookUpEdit_OM_1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            var Datos = new Dictionary<string, string>();
            bool byparam = (checkEdit_OM_2.Checked);
            if (byparam)
            {
                Datos.Add("p1", Decimal.Round((db["VE"]),4).ToString());
                Datos.Add("p2", textEdit_OM.Text);
                Datos.Add("p3", Evaluate(Datos, "(p1*650)/p2"));
            }
            else
            {
                var tr = GetByValue(gridLookUpEdit_OM_1.EditValue);
                if (tr != null)
                    Datos.Add("p1", tr["om"].ToString());
            }


            Maquina.ShowFormulates(Datos, FCOM, TLE.OscilacionMolde, byparam);
       }

        private void checkEdit_OM_1_Click(object sender, EventArgs e)
        {
            labelControl_OM_1.Enabled = sender == checkEdit_OM_1;
            gridLookUpEdit_OM_1.Enabled = sender == checkEdit_OM_1;
            labelControl_OM_2.Enabled = sender != checkEdit_OM_1;
            textEdit_OM.Enabled = sender != checkEdit_OM_1;
        }

        private void checkEdit_OM_2_Click(object sender, EventArgs e)
        {
            labelControl_OM_1.Enabled = sender == checkEdit_OM_1;
            gridLookUpEdit_OM_1.Enabled = sender == checkEdit_OM_1;
            labelControl_OM_2.Enabled = sender != checkEdit_OM_1;
            textEdit_OM.Enabled = sender != checkEdit_OM_1;
        }

        

        private void checkEdit_TS_1_Click(object sender, EventArgs e)
        {
            labelControl_TS_1.Enabled = sender == checkEdit_TS_1;
            gridLookUpEdit_TS.Enabled = sender == checkEdit_TS_1;
            labelControl_TS_3.Enabled = sender != checkEdit_TS_1;
            textEdit_TS_2.Enabled = sender != checkEdit_TS_1;
        }

        private void gridLookUpEdit_TS_Properties_EditValueChanged(object sender, EventArgs e)
        {
          var Datos = new Dictionary<string, string>();
            bool byparam = (checkEdit_TS_2.Checked);
            
            double arcocos = Math.Acos(double.Parse(db["VE"].ToString()) / (Math.PI * double.Parse(db["OM"].ToString()) * double.Parse(textEdit_TS_2.Text)));

            if (byparam)
            {
                Datos.Add("p1", db["om"].ToString());
                Datos.Add("p2", Decimal.Round((db["VE"]), 4).ToString());
                Datos.Add("p3", textEdit_TS_2.Text);
                Datos.Add("p6", arcocos.ToString());
                Datos.Add("p5", new Ecuation("((1/(3.1416*p1))*p6*60)", "", Datos).RightSide.Parameters.AsDouble().ToString());
            }
            else
            {
                var tr = GetByValue(gridLookUpEdit_TS.EditValue);
                if (tr != null)
                    Datos.Add("p1", tr["ts"].ToString());
            }


            Maquina.ShowFormulates(Datos, FCTS, TLE.TiempoSanado, byparam);
        }

        private void gridLookUpEdit_DMO_1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            var Datos = new Dictionary<string, string>();
            bool byparam = (sender == checkEdit_DMO_2);

            if (byparam)
            {
                Datos.Add("p1", (db["VE"] * 1000).ToString());
                Datos.Add("p2", db["OM"].ToString());
                Datos.Add("p3", Evaluate(Datos, "(p1/p2)"));
            }
            else
            {
                var tr = GetByValue(gridLookUpEdit_DMO_1.EditValue);
                if (tr != null)
                    Datos.Add("p1", tr["dmo"].ToString());
            }


            Maquina.ShowFormulates(Datos, FCDMO, TLE.DistanciaMarcaOscilacion, byparam);
        }

        private void checkEdit_DMO_1_Click(object sender, EventArgs e)
        {
            labelControl_DMO_1.Enabled = sender == checkEdit_DMO_1;
            gridLookUpEdit_DMO_1.Enabled = sender == checkEdit_DMO_1;
        }

        private void comboBoxEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            var num = dSDatos.LLenarZonas(int.Parse(comboBoxEdit1.Properties.Items[comboBoxEdit1.Properties.Items.Count - 1].ToString()), 50 - int.Parse(comboBoxEdit1.EditValue.ToString()));
            comboBoxEdit2.Properties.Items.Clear();
            for (int i = 0; i < num.Count; i++ )
                comboBoxEdit2.Properties.Items.Add(num[i]);

            if (comboBoxEdit2.EditValue != null && comboBoxEdit1.EditValue != null)
                {
                    labelControl6.Text = (100 - double.Parse(comboBoxEdit1.EditValue.ToString()) - double.Parse(comboBoxEdit2.EditValue.ToString())).ToString();
                }

            ///////////////////////////////////////////////////////////////////////////
            if (comboBoxEdit1.EditValue != null && comboBoxEdit2.EditValue != null && labelControl6.Text!="" && comboBoxEdit4.EditValue != null && comboBoxEdit5.EditValue != null)
            {
                var Datos = new Dictionary<string, string>();
                bool byparam = (checkEdit_ES_2.Checked);
                    
                if (byparam)
                {
                    Datos.Add("p1", comboBoxEdit4.EditValue.ToString());
                    Datos.Add("p2", comboBoxEdit5.EditValue.ToString());
                    Datos.Add("p3", decimal.Round(db["VE"],4).ToString());
                    Datos.Add("d1", comboBoxEdit1.EditValue.ToString());
                    Datos.Add("d2", comboBoxEdit2.EditValue.ToString());
                    Datos.Add("d3", labelControl6.Text);
                    Datos.Add("p4", Evaluate(Datos, "(130* (p1 + (0.007 *p2)) * p3)"));
                    Datos.Add("p5", Evaluate(Datos, "(d1*p4/100)"));
                    Datos.Add("p6", Evaluate(Datos, "(d2*p4/100)"));
                    Datos.Add("p7", Evaluate(Datos, "(d3*p4/100"));
                    
                }
                else
                {
                    var tr = GetByValue(gridLookUpEdit_ES.EditValue);
                    if (tr != null)
                        Datos.Add("p1", tr["esz1"].ToString());
                        Datos.Add("p2", tr["esz2"].ToString());
                        Datos.Add("p3", tr["esz3"].ToString());
                }


                Maquina.ShowFormulates(Datos, FCES, TLE.EnfriamSecZona, byparam);
            }
        }

        private void textEdit_AL_1_EditValueChanged(object sender, EventArgs e)
        {
            var Datos = new Dictionary<string, string>();
            bool byparam = (sender == checkEdit_AL_2);

            if (byparam)
            {
                Datos.Add("p1", textEdit_AL_1.Text);
                Datos.Add("p2", textEdit_AL_2.Text);
                Datos.Add("p3", Evaluate(Datos, "(p1*p2)"));
            }
            else
            {
                var tr = GetByValue(gridLookUpEdit_AL.EditValue);
                if (tr != null)
                    Datos.Add("p1", tr["al"].ToString());
            }


            Maquina.ShowFormulates(Datos, FCAL, TLE.AceiteLubricacion, byparam);
        }

        private void checkEdit_AL_1_Click(object sender, EventArgs e)
        {
            labelControl_AL_1.Enabled = sender == checkEdit_AL_1;
            gridLookUpEdit_AL.Enabled = sender == checkEdit_AL_1;
            labelControl_AL_2.Enabled = sender != checkEdit_AL_1;
            textEdit_AL_1.Enabled = sender != checkEdit_AL_1;
            labelControl_AL_3.Enabled = sender != checkEdit_AL_1;
            textEdit_AL_2.Enabled = sender != checkEdit_AL_1;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var data = dSDatos.T_Tecnologia.NewT_TecnologiaRow();
            data.codigo = int.Parse(textEdit3.EditValue.ToString());
            data.idacero = int.Parse(gridLookUpEdit1.EditValue.ToString());
           // data.idmaquina = int.Parse(gridLookUpEdit2.EditValue.ToString());
            data.idpalanquilla = int.Parse(gridLookUpEdit3.EditValue.ToString());
            data.longitud = int.Parse(textEdit1.EditValue.ToString());
         /*   data.lo = db["LO"].ToString();
            data.vc = db["VC"].ToString();
            data.ve = db["VE"].ToString();
            data.tipac = db["TIPAC"].ToString();
            data.tipad = db["TIPAD"].ToString();
            data.lmcal = db["LMCAL"].ToString();
            data.ctt = db["CTT"].ToString();
            data.cmae = db["CMAE"].ToString();
            data.vma = db["VMA"].ToString();
            data.ep = db["EP"].ToString();
            data.om = db["OM"].ToString();
            data.ts = db["TS"].ToString();
            data.dmo = db["DMO"].ToString();
            data.esz1 = db["ESZ1"].ToString();
            data.esz2 = db["ESZ2"].ToString();
            data.esz3 = db["ESZ3"].ToString();
            data.al = db["AL"].ToString();
          * 
          * 
          * foreach (string k in db.Keys)
            {
                var data = dSDatos.Temp.NewTempRow();
                data.codigo = textEdit3.EditValue.ToString();
                data.Acero = Acero.namemarca.ToString();
                data.Maquina = Maquina.marcamaquina.ToString();
                data.Palanquilla = Palanquilla.tipopalanquilla.ToString();
                data.longitud = textEdit1.EditValue.ToString();
                data.parametro = k;
                data.valor = db[k].ToString();
                data.um="aaa";
                
                dSDatos.Temp.AddTempRow(data);
            }*/
            data.AcceptChanges();
            dSDatos.T_Tecnologia.AddT_TecnologiaRow(data);
            
            t_TecnologiaTableAdapter.Update(dSDatos.T_Tecnologia); 
            
            /* 
            dSDatos.AcceptChanges();
            var frmreport = new FrmReport();
            frmreport.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\RepTecnologia.repx",dSDatos.Temp,null);
            frmreport.ShowDialog(this);
            */
        }

        private ExplorationAlgorithm.Simulate _wf;

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
        

        }




















    }

}