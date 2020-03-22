using System.Collections.Generic;
using UnityEngine;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using Curve = Unity.UIWidgets.animation.Curve;
using Curves = Unity.UIWidgets.animation.Curves;
using OffsetTween = Unity.UIWidgets.animation.OffsetTween;
using CurveTween = Unity.UIWidgets.animation.CurveTween;
using Unity.UIWidgets.rendering;

public class BottomBar_Demo : UIWidgetsPanel
{
    protected override void OnEnable()
    {
        // add material icons, familyName must be "Material Icons"
        FontManager.instance.addFont(Resources.Load<Font>("fonts/MaterialIcons-Regular"), "Material Icons");

        base.OnEnable();
    }

    protected override Widget createWidget()
    {
        return new BottomBar();
    }
}

public class BottomBar : StatefulWidget
{
    public override State createState()
    {
        return new _BottomBarState();
    }

    class _BottomBarState : State<BottomBar> 
    {
        int _cIndex = 0;

        void _incrementTab(int index)
        {
            setState(() => {
                _cIndex = index;
            });
        }

        public override Widget build(BuildContext context)
        {
            return new MaterialApp(
                home: new Scaffold(
                    appBar: new AppBar(
                        title: new Text("Flutter Bottombar")
                    ),
                    body: new Center(
                        child: new Column(
                            mainAxisAlignment: MainAxisAlignment.center,
                            children: new List<Widget>()
                            {
                                new Text("BottomBar")
                            }
                        )
                    )
                )
            );
        }
    }
}