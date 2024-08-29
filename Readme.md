<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128620676/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3666)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Popup Container Editor - Display the default OK button in the dropdown

This example creates a custom popup container editor that displays the default OK button in the popup window.

![WinForms Popup Container Editor - Display the default OK button in the dropdown](https://raw.githubusercontent.com/DevExpress-Examples/how-to-display-the-default-ok-button-in-the-popupcontaineredits-popup-window-e3666/13.1.4+/media/62056426-487b-11e4-80ba-00155d624807.png)

```csharp
class PopupContainerFormOkButton : PopupContainerForm {
    public PopupContainerFormOkButton(PopupContainerEditOKButton ownerEdit) : base(ownerEdit) {}
    protected override void SetupButtons(){
        UpdatePopupButtons();
    }
    internal void UpdatePopupButtons() {
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
    // ...
}
```


## Files to Review

* [MainForm.cs](./CS/MainForm.cs) (VB: [MainForm.vb](./VB/MainForm.vb))
* [PopupContainerEditOKButton.cs](./CS/PopupContainerEditOKButton.cs) (VB: [RepositoryItemPopupContainerEditOKButton.vb](./VB/RepositoryItemPopupContainerEditOKButton.vb))
* [PopupContainerFormOkButton.cs](./CS/PopupContainerFormOkButton.cs) (VB: [PopupContainerFormOkButton.vb](./VB/PopupContainerFormOkButton.vb))
* [RepositoryItemPopupContainerEditOKButton.cs](./CS/RepositoryItemPopupContainerEditOKButton.cs) (VB: [RepositoryItemPopupContainerEditOKButton.vb](./VB/RepositoryItemPopupContainerEditOKButton.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-popup-container-edit-with-default-ok-button&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-popup-container-edit-with-default-ok-button&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
