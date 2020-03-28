using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.widgets;

public class Settings : StatefulWidget
{
    public override State createState()
    {
        return new _SettingsState();
    }

    class _SettingsState : State<Settings>
    {
        public override void initState()
        {
            base.initState();
        }

        public override void dispose()
        {
            base.dispose();
        }

        public override Widget build(BuildContext context) 
        {
            return new Scaffold(
                appBar: new AppBar(
                    title: new Text(
                        "消息",
                        style: new TextStyle(
                            color: Colors.black,
                            fontSize: 32
                        )
                    ),
                    backgroundColor: Colors.white,
                    elevation: 0, //阴影
                    actionsIconTheme: new IconThemeData(
                        size: 30.0f,
                        color: Colors.black,
                        opacity: 10.0f
                    ),
                    actions: new List<Widget>()
                    {
                        new Padding(
                            padding: EdgeInsets.only(right: 8.0f),
                            child: new GestureDetector(
                                onTap: () =>
                                {
                                    Debug.Log("搜索");
                                },
                                child: new Image(image: new AssetImage("search@1x"))
                            )
                        ),
                        new Padding(
                            padding: EdgeInsets.only(right: 12.0f),
                            child: new GestureDetector(
                                onTap: () =>
                                {
                                    Debug.Log("更多");
                                },
                                child: new Image(image: new AssetImage("profile@1x"))
                            )
                        )
                    }
                )
            );
        }
    }
}
