using InputMapperWinForm.Helpers;
using System;
using System.Windows.Forms;

namespace InputMapperWinForm.Presentation.CustomControls
{
    public partial class UCtrlActionMapPanel : UserControl
    {
        private static KeyboardInputEvent.VKCodesEnum[] _items;
        internal ExposedControls ExposedControls { get; private set; }

        public UCtrlActionMapPanel()
        {
            InitializeComponent();
            SetExposedControls();
            LoadDropDownLists();
        }

        private void SetExposedControls()
        {
            ExposedControls = new ExposedControls
            {
                OriginalActionCmb = ddlOriginalAction,
                NewActionCmb = ddlNewAction,
                AddNewButton = btnAdd,
                DeleteButton = btnDel
            };
        }

        private void LoadDropDownLists()
        {
            _items = Enum.GetValues<KeyboardInputEvent.VKCodesEnum>();
            LoadDataInGridDropDownList(ddlOriginalAction);
            LoadDataInGridDropDownList(ddlNewAction);
        }

        private void LoadDataInGridDropDownList(ComboBox ddl)
        {
            ddl.DisplayMember = "Description";
            ddl.ValueMember = "Value";
            ddl.DataSource = new BindingSource() { DataSource = _items };
            //foreach (var item in _items)
            //{
            //    ddl.Items.Add(new ComboboxItem
            //    {
            //        Description = EnumHelper.GetEnumDescription(item),
            //        Value = item
            //    });
            //}
        }
    }

    internal class ExposedControls
    {
        public ComboBox OriginalActionCmb { get; set; }
        public ComboBox NewActionCmb { get; set; }
        public Button AddNewButton { get; set; }
        public UCtrlButton DeleteButton { get; set; }
    }

    internal class ComboboxItem
    {
        internal string Description { get; set; }
        internal KeyboardInputEvent.VKCodesEnum Value { get; set; }
    }
}
