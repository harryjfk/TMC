using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Ribbon;

namespace TMC.ACATTA
{
    public class ACATTAModule:Module
    {
        public ACATTAModule(ModuleList list) : base(list) { }
        protected override string GetName()
        {
            return "TTA";
        }
        public override void CreatePage(DevExpress.XtraBars.Ribbon.RibbonPage page)
        {
            base.CreatePage(page);
            var frmMain = new FrmMain();
            foreach (RibbonPageGroup item in frmMain.Ribbon.Pages[0].Groups)
                page.Groups.Add(item);

            page.Image = frmMain.Icon.ToBitmap();
            
        }
    }
}
