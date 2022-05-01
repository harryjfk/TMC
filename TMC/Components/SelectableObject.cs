using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TMC.Components
{
    [Serializable]
    public class UCSelectableControl : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void SelectedEvent(SelectableObject SelectableObject);

        public event SelectedEvent OnSelectedChanged;
        public event SelectedEvent OnSelectedResize;

        internal void DoChanged(SelectableObject obj)
        {
            if (OnSelectedChanged != null)
                OnSelectedChanged(obj);

        }

        internal void DoSelectedResize(SelectableObject o)
        {
            if (OnSelectedResize != null)
                OnSelectedResize(o);
        }
    }
    [Serializable]
    public class SelectableObject
    {
        [NonSerialized]
        protected UCSelectableControl _selectControl;
        public SelectableObject() { }
        public SelectableObject(UCSelectableControl control)
        {
            _selectControl = control;
        }

        public Color SelectColor { get; set; }
        public Color HoverColor { get; set; }
        private bool _selected;
        public bool Selected
        {
            get { return _selected; }
            set
            {

                if (_selectControl != null && _selected != value)
                    _selectControl.DoChanged(this);
                _selected = value;
            }
        }

        public bool Hovered { get; set; }
    }
}
