using System;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TMC.BCE
{


    public partial class DSBCE
    {
        
    
        partial class T_Balance_EcuacionDataTable
        {
            public double GetEcuacion(int i, String Concepto)
            {
                var r= this[i];
                return (double)r[Concepto];
            }
        }
        partial class T_Indice_ConsumoDataTable
        {
            public double FindByName(string Name)
            {
                return (from t in this where t.T_Balance_PropiedadRow.name_Balance_P == Name select t.value_Indice_C) .FirstOrDefault();
            }
        }
        partial class Q_ElementosProjectDataTable
        {
            public double SearchCarga(string nameelemento, string propiedad, string tipopropiedad)
            {
                 
                var  s= (from t in this
                        where t.codelemento == nameelemento && t.name_Balance_P == propiedad && t.nametipopropiedadbalance == tipopropiedad
                        select t.valor).FirstOrDefault();
                if (tipopropiedad == "Carga Refractaria Fundente")
                    s /= 100;
                return s;
            }
        }
    }
}

namespace TMC.BCE.DSBCETableAdapters {
    
    
    public partial class T_Patron_BalanceTableAdapter {
    }
}
