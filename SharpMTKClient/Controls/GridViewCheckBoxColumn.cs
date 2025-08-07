using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

[ToolboxBitmap(typeof(DataGridViewCheckBoxColumn))]
public partial class GridViewCheckBoxColumn : DataGridViewCheckBoxColumn
{
    public GridViewCheckBoxColumn()
    {
        throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
    }

    private void datagridViewCheckBoxHeaderCell_OnCheckBoxClicked(int columnIndex, bool state)
    {
        throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
    }
}

public delegate void CheckBoxClickedHandler(int columnIndex, bool state);
public partial class DataGridViewCheckBoxHeaderCellEventArgs : EventArgs
{
    private bool _bChecked;
    public DataGridViewCheckBoxHeaderCellEventArgs(int columnIndex, bool bChecked)
    {
        throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
    }

    public bool Checked
    {
        get
        {
            return _bChecked;
        }
    }
}

public partial class DatagridViewCheckBoxHeaderCell : DataGridViewColumnHeaderCell
{
    private Point checkBoxLocation;
    private Size checkBoxSize;
    private bool _checked = false;
    private Point _cellLocation = new Point();
    private CheckBoxState _cbState = CheckBoxState.UncheckedNormal;
    public event CheckBoxClickedHandler OnCheckBoxClicked;
    public DatagridViewCheckBoxHeaderCell()
    {
        throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
    }

    protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates dataGridViewElementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
    {
        throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
    }

    protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
    {
        throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
    }
}

public partial class DataGridViewColumnSelector
{
    private DataGridView mDataGridView = default;
    private CheckedListBox mCheckedListBox;
    private ToolStripDropDown mPopup;
    public int MaxHeight = 300;
    public int Width = 200;
    public DataGridView DataGridView
    {
        get
        {
            return mDataGridView;
        }

        set
        {
            if (mDataGridView != null)
                mDataGridView.CellMouseClick += new DataGridViewCellMouseEventHandler(mDataGridView_CellMouseClick);
            mDataGridView = value;
            if (mDataGridView != null)
                mDataGridView.CellMouseClick += new DataGridViewCellMouseEventHandler(mDataGridView_CellMouseClick);
        }
    }

    private void mDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
    }

    public DataGridViewColumnSelector()
    {
        throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
    }

    public DataGridViewColumnSelector(DataGridView dgv) : this()
    {
        throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
    }

    private void mCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
    {
        throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
    }
}