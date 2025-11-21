# How to Select Items Programmatically in SfComboBox
This example demonstrates how to select items programmatically in the Syncfusion WinForms SfComboBox control. The SfComboBox supports multi-selection, making it useful for scenarios where you need to select items dynamically through code rather than user interaction. This is particularly helpful for:
- Loading saved preferences.
- Applying default selections.
- Responding to application logic.

## Why This Is Useful
- **Dynamic Selection**: Automatically select items based on conditions.
- **Improved UX**: Pre-load user preferences or defaults.
- **Flexibility**: Control selection without manual input.

## Key Approach
Use the CheckedItems property of the DropDownListView to programmatically select items. By iterating through the items collection, you can add items to the checked list, ensuring they appear selected in the dropdown.

## Code Example

```C#
private void InitializeComponent()
{
    this.sfComboBox1 = new Syncfusion.WinForms.ListView.SfComboBox();
    ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).BeginInit();
    this.SuspendLayout();

    // sfComboBox1
    this.sfComboBox1.ComboBoxMode = Syncfusion.WinForms.ListView.Enums.ComboBoxMode.MultiSelection;
    this.sfComboBox1.Location = new System.Drawing.Point(167, 76);
    this.sfComboBox1.Name = "sfComboBox1";
    this.sfComboBox1.Size = new System.Drawing.Size(171, 37);
    this.sfComboBox1.TabIndex = 0;

    // Form1
    this.ClientSize = new System.Drawing.Size(535, 294);
    this.Controls.Add(this.sfComboBox1);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "SfComboBox_Selection";

    ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).EndInit();
    this.ResumeLayout(false);
}

public Form1()
{
    // Bind data source
    sfComboBox1.DataSource = GetTable();
    sfComboBox1.DisplayMember = "Patient";
    sfComboBox1.ValueMember = "Drug";

    // Programmatically select all items
    foreach (var item in sfComboBox1.DropDownListView.View.Items.ToList())
    {
        sfComboBox1.DropDownListView.CheckedItems.Add(item);
    }
}

private DataTable GetTable()
{
    DataTable table = new DataTable();
    table.Columns.Add("Dosage", typeof(int));
    table.Columns.Add("Drug", typeof(string));
    table.Columns.Add("Patient", typeof(string));

    table.Rows.Add(25, "Indocin", "David");
    table.Rows.Add(50, "Enebrel", "Sam");
    table.Rows.Add(10, "Hydralazine", "Christoff");
    table.Rows.Add(21, "Combivent", "Janet");
    table.Rows.Add(100, "Dilantin", "Melanie");

    return table;
}
```

## Reference
For more details, refer to the official Syncfusion Knowledge Base article: [How to select DropDown items in SfComboBox](https://wwwnforms-sfcombobox-dropdown-items-programmatically)
