using UnityEngine;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.widgets;
using Unity.UIWidgets.material;

public class Drawer_Demo : UIWidgetsPanel
{
    protected override void OnEnable()
    {
        FontManager.instance.addFont(Resources.Load<Font>("fonts/MaterialIcons-Regular"), "Material Icons");

        base.OnEnable();
    }

    protected override Widget createWidget()
    {
        return new MaterialApp(
            title: "Flutter Demo",
            theme: new ThemeData(
                primarySwatch: Colors.brown
            ),
            home: new DrawerWidget()
        );
    }
}
