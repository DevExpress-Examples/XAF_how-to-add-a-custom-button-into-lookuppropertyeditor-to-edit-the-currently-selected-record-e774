using System;
using DevExpress.ExpressApp;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.ExpressApp.Model;

namespace WinSolution.Module.Win {
    public class MyLookupPropertyEditor : LookupPropertyEditor {
        public MyLookupPropertyEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model) { }
        protected override void SetupRepositoryItem(DevExpress.XtraEditors.Repository.RepositoryItem item) {
            base.SetupRepositoryItem(item);
            ((RepositoryItemLookupEdit)item).Init(this, DisplayFormat, this.Helper);
            AppearanceObject appearance = new AppearanceObject();
            appearance.Font=new Font(FontFamily.GenericSansSerif, 10F, FontStyle.Underline);
            ((RepositoryItemLookupEdit)item).Buttons.Add(new EditorButton(ButtonPredefines.Glyph, "Edit", -1, true, true, true, HorzAlignment.Default, null, new KeyShortcut(System.Windows.Forms.Keys.Enter), appearance, "Press this button to edit the object"));
            ((RepositoryItemLookupEdit)item).ButtonClick += new ButtonPressedEventHandler(MyLookupPropertyEditor_ButtonClick);
        }
        void MyLookupPropertyEditor_ButtonClick(object sender, ButtonPressedEventArgs e) {
            if (!e.Button.IsDefaultButton) {
                IObjectSpace objectSpace = Helper.Application.CreateObjectSpace();
                object editedObject = null;
                if (BindingHelper != null) {
                    editedObject = objectSpace.GetObject(BindingHelper.GetControlValue());
                }
                else if (sender is LookupEdit) {
                    editedObject = objectSpace.GetObject((sender as LookupEdit).EditValue);
                }
                if (editedObject != null) {
                    ShowViewParameters svp = new ShowViewParameters();
                    svp.CreatedView = Helper.Application.CreateDetailView(objectSpace, editedObject, true);
                    svp.TargetWindow = TargetWindow.Default;
                    svp.Context = TemplateContext.View;
                    svp.CreateAllControllers = true;
                    ShowViewSource svs = new ShowViewSource(Helper.Application.MainWindow, null);
                    Helper.Application.ShowViewStrategy.ShowView(svp, svs);
                }
            }
        }
    }
}
