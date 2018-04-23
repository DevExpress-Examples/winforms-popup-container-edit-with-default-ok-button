using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace PopupContainerControlWithOKButton
{
    class PopupContainerEditOKButton : PopupContainerEdit
    {
        // static constructor
        static PopupContainerEditOKButton() { RepositoryItemPopupContainerEditOKButton.RegisterPopupContainerEditOKButton(); }

        // public constructor
        public PopupContainerEditOKButton() { }

        // ovverride property
        public override string EditorTypeName
        {
            get { return RepositoryItemPopupContainerEditOKButton.PopupContainerEditOKButtonEditorName; }
        }

        // property as corresponded repositoryitem
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemPopupContainerEditOKButton Properties
        {
            get { return base.Properties as RepositoryItemPopupContainerEditOKButton; }
        }

        protected override DevExpress.XtraEditors.Popup.PopupBaseForm CreatePopupForm()
        {
            return new PopupContainerFormOkButton(this);
        }
    }
}
