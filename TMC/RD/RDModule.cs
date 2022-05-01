using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Ribbon;

namespace TMC.RD
{
    public class RDModule:Module
    {
        public RDModule(ModuleList list) : base(list) { }
        protected override string GetName()
        {
            return "RD";
        }
        public void CopyDockPanel(DockPanel src,DockPanel dest)
        {
            dest.Text = src.Text;
            while (src.ControlContainer.Controls.Count > 0)
                src.ControlContainer.Controls[0].Parent = dest;
            
        }
        public override void CreatePage(DevExpress.XtraBars.Ribbon.RibbonPage page)
        {
            base.CreatePage(page);
            var frmMain = new FrmMain();
            frmMain.FrmMain_Load(null,null);
            ModuleList.MasterForm.OnChildChanged += frmMain.xtraTabbedMdiManager1_SelectedPageChanged;
            foreach (RibbonPageGroup item in frmMain.Ribbon.Pages[0].Groups)
                page.Groups.Add(item);

            page.Image = frmMain.Icon.ToBitmap();

          
            var r =ModuleList.MasterForm.DockManager.AddPanel(DockingStyle.Left);
            r.VisibilityChanged += frmMain.dockPanel1_VisibilityChanged;
            r.Tag = frmMain.barButtonItem6;
            CopyDockPanel(frmMain.dockPanel1,r);
            frmMain.barButtonItem6.Tag = r;
            r = ModuleList.MasterForm.DockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Right);
            CopyDockPanel(frmMain.dockPanel3,r);
            frmMain.barButtonItem9.Tag = r;
            r.VisibilityChanged += frmMain.dockPanel1_VisibilityChanged;
            r.Tag = frmMain.barButtonItem9;
            var p = r.AddPanel();
            p.Tabbed = true;
            p.VisibilityChanged += frmMain.dockPanel1_VisibilityChanged;
            frmMain.barButtonItem11.Tag = p;
            p.Tag = frmMain.barButtonItem11;
            CopyDockPanel(frmMain.dockPanel2, p);
          frmMain.xtraTabbedMdiManager1_SelectedPageChanged(ModuleList.MasterForm,null);
        }

    }
}
