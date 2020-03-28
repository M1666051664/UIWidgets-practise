using System.Collections.Generic;
using UnityEngine;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.service;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UIWidgets.Runtime.material;

public class AppBar_Demo : UIWidgetsPanel
{
    protected override void OnEnable()
    {
        // if you want to use your own font or font icons.
        // FontManager.instance.addFont(Resources.Load<Font>(path: "path to your font"), "font family name");

        // load custom font with weight & style. The font weight & style corresponds to fontWeight, fontStyle of
        // a TextStyle object
        // FontManager.instance.addFont(Resources.Load<Font>(path: "path to your font"), "Roboto", FontWeight.w500,
        //    FontStyle.italic);

        // add material icons, familyName must be "Material Icons"
        FontManager.instance.addFont(Resources.Load<Font>("fonts/MaterialIcons-Regular"), "Material Icons");

        base.OnEnable();
    }

    protected override Widget createWidget()
    {
        return new AppBarWidget();
    }
}

public class AppBarWidget : StatelessWidget
{
    public override Widget build(BuildContext context)
    {
        return new MaterialApp(
            home: new Scaffold(
                appBar: new AppBar(
                    title: new Text("Hello Appbar"),
                    //leading: new Icon(
                    //    Icons.menu //需要导入字体资源
                    //),
                    leading: new GestureDetector(
                        onTap: () => 
                        {
                            Debug.Log("给Icon包一层点击事件");
                        },
                        child: new Icon(
                            Icons.menu
                        )
                    ),
                    automaticallyImplyLeading: false, //与leading配合使用，自动关联图标
                    actionsIconTheme: new IconThemeData(
                        size: 30.0f,
                        color: Colors.red,
                        opacity: 10.0f
                    ),
                    actions: new List <Widget>()
                    {
                        new Padding(
                            padding: EdgeInsets.only(right: 20.0f),
                            child: new GestureDetector(
                                onTap: () =>
                                {
                                    Debug.Log("搜索");
                                },
                                child: new Icon(
                                    Icons.search,
                                    size: 26.0f
                                )
                            )
                        ),
                        new Padding(
                            padding: EdgeInsets.only(right: 20.0f),
                            child: new GestureDetector(
                                onTap: () =>
                                {
                                    Debug.Log("更多");
                                },
                                child: new Icon(
                                    Icons.more_vert
                                )
                            )
                        )
                    }
                )
            )
        );
    }
}
