# How to add a custom button into LookupPropertyEditor to edit the currently selected record


<p>You can open the detail form for the currently selected object if you press Ctrl+Shift while clicking the editor. Another way is to implement your own editor, derived from the DevExpress.ExpressApp.Win.Editors.LookupPropertyEditor, which will provide a specific functionality you need.<br />Fact is that the LookupPropertyEditor is represented in a detail view by the LookUpEdit control, which allows various customizations. So, you can customize it by adding a special button that will invoke a Detail View for the selected object or even allow your users to create new records directly.<br /><br /><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-add-a-custom-button-into-lookuppropertyeditor-to-edit-the-currently-selected-record-e774/13.1.4+/media/94d807ac-64cf-11e4-80ba-00155d624807.png"><br /><br /><strong>See Also:</strong></p>
<p><a href="https://www.devexpress.com/Support/Center/p/e1101">How to work with referenced properties via a simple drop down list instead of the standard LookupPropertyEditor (Example)</a></p>

<br/>


