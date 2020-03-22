using UnityEngine;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.widgets;

public class HelloWorld_Demo : UIWidgetsPanel
{
    protected override Widget createWidget()
    {
        return new HelloWorld();
    }
}
