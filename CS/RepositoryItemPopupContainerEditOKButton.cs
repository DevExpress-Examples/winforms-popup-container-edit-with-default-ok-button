using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using System.ComponentModel;

namespace PopupContainerControlWithOKButton
{
    class RepositoryItemPopupContainerEditOKButton : RepositoryItemPopupContainerEdit
    {
        // static constructor which calls static registration method
        static RepositoryItemPopupContainerEditOKButton() { RegisterPopupContainerEditOKButton(); }

        // static register method
        public static void RegisterPopupContainerEditOKButton()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(
                PopupContainerEditOKButtonEditorName,
                typeof(PopupContainerEditOKButton),
                typeof(RepositoryItemPopupContainerEditOKButton),
                typeof(PopupContainerEditViewInfo),
                new ButtonEditPainter(),
                true,
                null));
        }

        // internal editor name
        internal const string PopupContainerEditOKButtonEditorName = "PopupContainerEditOKButton";

        // public constructor
        public RepositoryItemPopupContainerEditOKButton() : base()
        {
            protShowOkButton = true;
        }

        protected bool protShowOkButton;
        [Description("Determines whether the Ok button will be displayed in the popup form or not.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public bool ShowOkButton
        {
            get { return protShowOkButton; }
            set { if (value != protShowOkButton) protShowOkButton = value; }
        }

        // ovverride property
        public override string EditorTypeName
        {
            get { return PopupContainerEditOKButtonEditorName; }
        }

        public override void Assign(RepositoryItem item)
        {
            base.Assign(item);
            RepositoryItemPopupContainerEditOKButton currentRepository = (item as RepositoryItemPopupContainerEditOKButton);
            this.ShowOkButton = currentRepository.ShowOkButton;
        }
    }
}
