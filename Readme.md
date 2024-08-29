<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128623235/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T378801)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->

# WinForms LookupEdit - Standard Binding (Simple Data Types)

This example shows how to create and configure an in-place LookUpEdit control (`RepositoryItemLookUpEdit`) for editing cells in a grid column.

The lookup editor is used to edit the **CategoryID** field values from the `Products` list. The lookup editor displays corresponding category names in the edit box. 

Use the following properties to bind the LookUpEdit control to data:

* [DataSource](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemLookUpEditBase.DataSource) - Specifies the source of records.
* [DisplayMember](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemLookUpEditBase.DisplayMember) - The data source field whose values are visible to users. A value from this field is displayed in the lookup’s text box when a user selects a record. 
* [ValueMember](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemLookUpEditBase.ValueMember) - The data source field with unique/key values. A value from this data field is assigned to the lookup's `EditValue` property when a user selects a record. When a lookup editor is used to edit cell values in the Data Grid, the type of the `ValueMember` field must match the type of the field assigned to the grid's lookup column (GridColumn.FieldName). Enable the lookup's [ThrowExceptionOnInvalidLookUpEditValueType](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemLookUpEditBase.ThrowExceptionOnInvalidLookUpEditValueType) option to detect data type issues.

## Files to Review

* [Form1.cs](./CS/LookupEdit-StandardBinding/Form1.cs) (VB: [Form1.vb](./VB/LookupEdit-StandardBinding/Form1.vb))
* [Program.cs](./CS/LookupEdit-StandardBinding/Program.cs) (VB: [Program.vb](./VB/LookupEdit-StandardBinding/Program.vb))

## Documentation

* [Standard Binding (to Simple Data Types)](https://docs.devexpress.com/WindowsForms/116015/controls-and-libraries/editors-and-simple-controls/lookup-editors/standard-binding-to-simple-data-types)
* [Advanced Binding (to Business Objects)](https://docs.devexpress.com/WindowsForms/116016/controls-and-libraries/editors-and-simple-controls/lookup-editors/advanced-binding-to-business-objects)
* [Lookup Main Settings](https://docs.devexpress.com/WindowsForms/116029/controls-and-libraries/editors-and-simple-controls/lookup-editors/lookup-editors-and-main-settings)

## See Also

* [DevExpress WinForms Troubleshooting - LookUp Editors](https://go.devexpress.com/CheatSheets_WinForms_Examples_T929986.aspx)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-lookupedit-bind-to-simple-data-types&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-lookupedit-bind-to-simple-data-types&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
