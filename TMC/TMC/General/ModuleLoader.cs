using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMC.ACATTA;
using DevExpress.XtraBars.Ribbon;
using TMC.MCC;
using System.Windows.Forms;
using TMC.General.Reportes;
using TMC.RD;
using DevExpress.XtraBars.Docking;

namespace TMC
{
   
    public class MasterForm:RibbonForm
    {
        public static int Index { get { return 0; } }
        private ModuleList _modules = null;
   
        public void LoadModules()
        
        {
            Modules.Add(new ACATTAModule(Modules));
              Modules.Add(new MCCModule(Modules));
              Modules.Add(new RDModule(Modules));
              CreateModules();
        }
        protected virtual DockManager GetDockManager()
        {
            return null;
        }
        public Form CheckExists(Form form)
        {
            foreach (Form f in MdiChildren)
            if(f.GetType()==form.GetType())
                return f; return null;
        }
        public DockManager DockManager { get { return GetDockManager(); } }
        private void CreateModules()
        {
            foreach (var mod in Modules)
            {
                var r = new RibbonPage {Name = mod.Name + "modulePage", Visible = true, Text = mod.Name};
                mod.CreatePage(r);
                Ribbon.Pages.Insert(Ribbon.Pages.Count-1,r);
            }
        }
        public void UpdateChildsNormas()
        {
            foreach (var VARIABLE in MdiChildren)
                if (VARIABLE is NormaForm)
                    ((NormaForm) VARIABLE).RefreshData();
        }

        internal void ChildChanged()
        {
            if (OnChildChanged != null)
                OnChildChanged(this, null);
        }
        public EventHandler OnChildChanged { get; set; }
        public Form CreateForm(Form form,bool dialog = false)
        {
            var s = form;
            //if(!dialog)
            //form.MdiParent = this;
            if (dialog)
                s.ShowDialog(this);
            else
            {
                var r = CheckExists(form);
                if (r == null)
                    s.MdiParent = this;
                else
                    s = r;
                s.Show();
            }
            return s;
        }
        public FrmReporte ReporteForm { get { return new FrmReporte(); } }

        public ModuleList Modules
        {
            get
            {
                if (_modules == null) _modules = new ModuleList(this);
                return _modules;
            }
        }

    }
    public class ModuleList : List<Module>
    {
         private MasterForm _master;
         public ModuleList(MasterForm mf) { _master = mf; }
         public MasterForm MasterForm { get { return _master; } }
    }
    public abstract class Module
    {
        protected abstract String GetName();
        private RibbonPage _page;
       
        public String Name { get { return GetName(); } }
        public RibbonPage Page{get{return _page;}}
        private ModuleList _list;
        public Module(ModuleList list) { _list = list; }
        public ModuleList ModuleList { get { return _list; } }
        public virtual void CreatePage(RibbonPage page)
        {
            _page = page;
        }
    }

 public class NormaForm :DevExpress.XtraEditors.XtraForm
 {
     public virtual void RefreshData()
     {
     }
 }
}
