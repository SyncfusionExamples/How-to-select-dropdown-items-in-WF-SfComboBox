# How to Select Items Programmatically in SfComboBox
This repository provides a detailed example of how to select items programmatically in the WinForms SfComboBox control, which is part of the Syncfusion suite. The SfComboBox control allows users to select multiple items from a dropdown list, and in certain scenarios, you may need to select items dynamically through code rather than user interaction. This is particularly useful when implementing features like loading saved preferences, applying default selections, or responding to specific application logic.

The items can be selected programmatically using the CheckedItems property of the DropDownListView. By iterating through the items collection, you can add items to the checked list, ensuring they appear selected in the dropdown. This approach provides flexibility and control over the selection process without requiring manual input.

For more details, refer to the official Syncfusion Knowledge Base article:  
[How to select DropDown items in SfComboBox](https://wwwnforms-sfcombobox-dropdown-items-programmatically)

## Code Example (C#)
```csharp
foreach (var selectedItems in this.sfComboBox1.DropDownListView.View.Items.ToList())
{
    // Programmatically add the checked items
    this.sfComboBox1.DropDownListView.CheckedItems.Add(selectedItems);
}
