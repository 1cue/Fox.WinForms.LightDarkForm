# Fox.WinForms.LightDarkForm
Simple Extension for WinForms to make a Form (Window) automatically switch to Windows Light / Dark App Mode

## Add to your project

### Project Reference
Add the `Fox.WinForms.LightDarkForm` to your Solution and add Project Reference to `Fox.WinForms.LightDarkForm`.

You can also just add the `LightDarkForm.cs` from `Fox.WinForms.LightDarkForm` to your Project.

### NuGet Package
Simply add our `Fox.WinForms.LightDarkForm` NuGet Package to your project.

## How to use
We've just extended the defaut `Form` Class of WinForms with some little extra logic.

So please replace the base Class `Form` in your Form.cs Files with `LightDarkForm` and add `using Fox.WinForms.LightDarkForm;`.

Form.cs Before:
```
public partial class FormDemo : Form
{
    public FormDemo()
    {
        InitializeComponent();
    }
}
```

Form.cs After:
```
using Fox.WinForms.LightDarkForm;

public partial class FormDemo : LightDarkForm
{
    public FormDemo()
    {
        InitializeComponent();
    }
}
```

You can also have alook to our `Fox.WinForms.LightDarkForm.Test` Project.
