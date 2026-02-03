<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128587367/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E774)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# XAF WinForms - How to add a custom Edit button to LookupPropertyEditor

This example creates a [LookupPropertyEditor](https://docs.devexpress.com/eXpressAppFramework/113572/business-model-design-orm/data-types-supported-by-built-in-editors/reference-foreign-key-complex-type-properties#lookuppropertyeditor-1) descendant with a custom Edit button.
![image](https://github.com/DevExpress-Examples/XAF_how-to-add-a-custom-button-into-lookuppropertyeditor-to-edit-the-currently-selected-record-e774/assets/14300209/af3ac121-79d7-403d-9072-4e151cffd573)

## Implementation Details

Follow the steps below to add a custom button to LookupPropertyEditor:

1. Create a [LookupPropertyEditor](https://docs.devexpress.com/eXpressAppFramework/113572/business-model-design-orm/data-types-supported-by-built-in-editors/reference-foreign-key-complex-type-properties#lookuppropertyeditor-1) descendant ([MyLookupPropertyEditor.cs](CS/EFCore/LookUpButtonEF/LookUpButtonEF.Win/Editors/MyLookupPropertyEditor.cs)).

2. Access the [RepositoryItemLookupEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit) and use its settings to customize LookupPropertyEditor:
    * Add a custom button to the [Buttons](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit.Buttons) collection.
    * Subscribe to the [ButtonClick](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit.ButtonClick) event and implement custom logic in the event handler.
3. Assign the LookupPropertyEditor descendant to a business object's PropertyEditorType in the Model Editor ([Model.xafml](CS/EFCore/LookUpButtonEF/LookUpButtonEF.Win/Model.xafml)).

## Files to Review

- [Model.xafml](CS/EFCore/LookUpButtonEF/LookUpButtonEF.Win/Model.xafml) 
- [MyLookupPropertyEditor.cs](CS/EFCore/LookUpButtonEF/LookUpButtonEF.Win/Editors/MyLookupPropertyEditor.cs)

## Documentation

- [Customize a Built-in Property Editor (WinForms)](https://docs.devexpress.com/eXpressAppFramework/113104/ui-construction/view-items-and-property-editors/property-editors/customize-a-built-in-property-editor-winforms)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-win-custom-button-in-lookup-property-editor&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-win-custom-button-in-lookup-property-editor&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
