using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Drawing;

namespace PopupContainerControlWithOKButton
{
    class PopupContainerFormOkButton : PopupContainerForm
    {
        // constructor
        public PopupContainerFormOkButton(PopupContainerEditOKButton ownerEdit) : base(ownerEdit) {}

        // override methods
        protected override void SetupButtons()
        {
            UpdatePopupButtons();
        }

        new RepositoryItemPopupContainerEditOKButton Properties
        {
            get
            {
                PopupContainerEditOKButton edit = OwnerEdit as PopupContainerEditOKButton;
                if (edit == null) return null;
                return edit.Properties;
            }
        }
        internal void UpdatePopupButtons()
        {
            if (Properties == null) return;
            this.fShowOkButton = Properties.ShowOkButton;
            if (Properties.ShowPopupCloseButton)
                this.fCloseButtonStyle = Properties.ShowOkButton ? BlobCloseButtonStyle.Caption : BlobCloseButtonStyle.Glyph;
            else
                this.fCloseButtonStyle = BlobCloseButtonStyle.None;
            this.AllowSizing = Properties.PopupSizeable;
            if (!AllowSizing && !fShowOkButton && fCloseButtonStyle == BlobCloseButtonStyle.None)
                ViewInfo.ShowSizeBar = false;
        }
    }
}
