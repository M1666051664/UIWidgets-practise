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

public class PageRoute_Demo : UIWidgetsPanel
{
    protected override void OnEnable()
    {
        // add material icons, familyName must be "Material Icons"
        FontManager.instance.addFont(Resources.Load<Font>("fonts/MaterialIcons-Regular"), "Material Icons");

        base.OnEnable();
    }

    protected override Widget createWidget()
    {
        return new PageRoute();
    }
}

public class PageRoute : StatelessWidget
{
    public override Widget build(BuildContext context)
    {
        return new MaterialApp(
            home: new Page1()
        );
    }

    public static Widget _getCenterWidget(Widget child)
    {
        return new Scaffold(
            appBar: new AppBar(),
            body: new Center(
                child: child
            )
        );
    }

    // 无效果
    public static Route _createRoute()
    {
        return new PageRouteBuilder(
            pageBuilder: (context, animation, secondaryAnimation) => new Page2(),
            transitionsBuilder: (context, animation, secondaryAnimation, child) =>
            {
                return child;
            }
        );
    }
    // 从右往左
    public static Route _createRoute_RL()
    {
        return new PageRouteBuilder(
            pageBuilder: (context, animation, secondaryAnimation) => new Page2(),
            transitionsBuilder: (context, animation, secondaryAnimation, child) =>
            {
                Offset begin = new Offset(1.0f, 0.0f);
                Offset end = Offset.zero;
                Curve curve = Curves.ease;
                    //var tween = Tween(begin: begin, end: end).chain(new CurveTween(curve: curve));
                    var tween = new OffsetTween(begin: begin, end: end).chain(new CurveTween(curve: curve));
                return new SlideTransition(
                    position: animation.drive(tween),
                    child: child
                );
            }
        );
    }
    // 淡入效果
    public static Route _createRoute_Mat()
    {
        return new MaterialPageRoute(builder: (BuildContext context) => new Page2());
    }

    public class Page1 : StatelessWidget
    {
        public override Widget build(BuildContext context)
        {
            return new Scaffold(
                appBar: new AppBar(
                    title: new Text("Page1")
                ),
                body: new Center(
                    child: new RaisedButton(
                        child: new Text("Go!"),
                        onPressed: () =>
                        {
                            //Navigator.of(context).push(_createRoute());
                            //Navigator.of(context).push(_createRoute_RL());
                            Navigator.of(context).push(_createRoute_Mat());
                        }
                    )
                )
            );
        }
    }

    public class Page2 : StatelessWidget
    {
        public override Widget build(BuildContext context)
        {
            return new Scaffold(
                appBar: new AppBar(
                    title: new Text("Page2")
                ),
                body: new Center(
                    child: new Text("Page 2")
                )
            );
        }
    }

    public class Page3 : StatelessWidget
    {
        public override Widget build(BuildContext context)
        {
            Navigator.of(context).pop(); //1s后退出
            return _getCenterWidget(new Text("Page3"));
        }
    }
}