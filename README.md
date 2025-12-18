# How to Add an Icon in a Header of WinForms ContextMenuStripEx

This sample demonstrates how to add an icon inside the header of the **Syncfusion WinForms ContextMenuStripEx** control. By default, ContextMenuStripEx does not provide built‑in support for header icons, so a custom renderer must be implemented to draw the icon and header manually.  

## Overview

To achieve a header with an icon, the sample introduces a **CustomContextMenuStripEx** class that overrides painting and layout behavior. This approach enables adding a 16×16 icon and text at the top of the context menu, creating a visually enhanced and branded menu experience.  

### Key Concepts

- **Custom Rendering**: The `OnPaint` method is overridden to draw the header background, icon, and text.
- **DisplayRectangle Override**: Adjusts vertical space to make room for the header area.
- **GetPreferredSize Override**: Ensures the menu height accounts for the header.
- **Manual Icon Loading**: Icons are loaded from the project's `Images` folder and drawn inside the header.

## How It Works

1. **Create a Custom ContextMenuStripEx Class**  
   A new class inheriting from `ContextMenuStripEx` adds logic to paint a custom header containing the icon and title text.

2. **Override Layout Methods**  
   - `DisplayRectangle`: Shifts menu items downward based on header height.  
   - `GetPreferredSize`: Adds header height to the menu’s total size.  

3. **Draw the Header in OnPaint**  
   The sample uses `Graphics.FillRectangle`, `Graphics.DrawImage`, and `Graphics.DrawString` to render:
   - A header background strip  
   - A 16×16 icon  
   - The menu title (e.g., "Exit")  

4. **Initialize and Assign the Menu in Form**  
   In `Form1.cs`, the custom menu is created, header text is set, icons for menu items are loaded, and the customized menu is assigned to the form’s `ContextMenuStrip`. 

### Example Behavior

- The context menu displays a title bar at the top.
- The icon appears on the left side of the header.
- The menu title text appears next to the icon.
- Menu items (New, Copy, Cut) display their respective icons.  

## Benefits

- Enhances UI by providing a professional‑looking menu header.
- Gives designers flexibility to brand context menus.
- Allows custom arrangement of icons and text inside the header.

## Documentation

For more information, refer to the official Syncfusion knowledge base article:  
[**How to add an icon in a header of WinForms ContextMenuStripEx?**  ](https://support.syncfusion.com/kb/article/10354/how-to-add-an-icon-in-a-header-of-winforms-contextmenustripex)

---

### Requirements

Ensure that the following assemblies are referenced to use ContextMenuStripEx:

- Syncfusion.Tools.Windows
- Syncfusion.Grid.Base
- Syncfusion.Grid.Windows
- Syncfusion.Shared.Base
- Syncfusion.Shared.Windows
- Syncfusion.Tools.Base

---
