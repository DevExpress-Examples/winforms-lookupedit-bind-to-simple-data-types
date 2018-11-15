<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/LookupEdit-StandardBinding/Form1.cs) (VB: [Form1.vb](./VB/LookupEdit-StandardBinding/Form1.vb))
* [Program.cs](./CS/LookupEdit-StandardBinding/Program.cs) (VB: [Program.vb](./VB/LookupEdit-StandardBinding/Program.vb))
<!-- default file list end -->
# LookupEdit - Standard Binding (to Simple Data Types)


This example shows how to use an in-place LookUpEdit control (RepositoryItemLookUpEdit) for editing cells in a grid column.<br><br>The lookup editor in the example is used to edit the CategoryID field values from the Products list. However, instead of displaying category IDs, the editor will display corresponding category names in the edit box.<br><br>The main properties used to set up the LookUpEdit control are

* DataSource - Specifies the lookup data source.
* ValueMember - Specifies the field from the lookup data source whose values match the editor's edit value.
* DisplayMember - Identifies the field from the lookup data source whose values match the editor's display text.

<br/>


