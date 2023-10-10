﻿namespace System.Windows.Forms;
/// <summary>Contains various types of bitmaps that can appear on a <see cref="T:System.Windows.Forms.MenuItem"/>.</summary>
public enum MenuItemBitmapType {
    /// <summary>The user supplies their own image using the 'Image' property on the <see cref="T:System.Windows.Forms.MenuItem"/>.</summary>
    UserDefined,
    /// <summary>The bitmap is drawn by the window owner, and it must process both the 'WM_MEASUREITEM' and 'WM_DRAWITEM' messages.</summary>
    MenuCallback,
    /// <summary>Draws the windows icon or icon of the window specified in 'dwItemData'.</summary>
    System,
    /// <summary>Draws the restore button that appears on the menu bar.</summary>
    MbarRestore,
    /// <summary>Draws the minimize button that appears on the menu bar.</summary>
    MbarMinimize,
    /// <summary>Draws the close button that appears on the menu bar.</summary>
    MbarClose,
    /// <summary>Draws the disabled close button that appears on the menu bar.</summary>
    MbarCloseDisabled,
    /// <summary>Draws the disabled minimize button that appears on the menu bar.</summary>
    MbarMinimizeDisabled,
    /// <summary>Draws the close button that appears on the submenu.</summary>
    PopupClose,
    /// <summary>Draws the restore button that appears on the submenu.</summary>
    PopupRestore,
    /// <summary>Draws the maximize button that appears on the submenu.</summary>
    PopupMaximize,
    /// <summary>Draws the minimize button that appears on the submenu.</summary>
    PopupMinimized,
}