# How-to-select-dropdown-items-in-WF-SfComboBox
This repository contains the sample that how to select the dropdown items in the WinForms SfComboBox control. For more details please refer [How to select DropDown items in SfComboBox](https://www.syncfusion.com/kb/12155/how-to-select-the-winforms-sfcombobox-dropdown-items-programmatically).

# C#
    foreach (var selectedItems in this.sfComboBox1.DropDownListView.View.Items.ToList())
    {
      //Programmatically add the checked items
      this.sfComboBox1.DropDownListView.CheckedItems.Add(selectedItems);
    }

![Programtically select DropDown items](SfComboBox_Select_Dropdownitems/Images/Select%20DropDown%20Items.png)
