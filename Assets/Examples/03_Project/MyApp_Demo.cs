using UnityEngine;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using Unity.UIWidgets.foundation;
using Unity.UIWidgets.material;
using Color = Unity.UIWidgets.ui.Color;

public class MyApp_Demo : UIWidgetsPanel
{
    protected override void OnEnable()
    {
        FontManager.instance.addFont(Resources.Load<Font>("fonts/MaterialIcons-Regular"), "Material Icons");

        base.OnEnable();
    }

    protected override Widget createWidget()
    {
        return new MyApp();
    }
}

public class MyApp : StatelessWidget
{
    public override Widget build(BuildContext context)
    {
        return new MaterialApp(
            home: new Home()
        );
    }
}