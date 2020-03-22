using System.Collections.Generic;
using UnityEngine;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.widgets;

public class DrawerWidget : StatefulWidget
{
    public override State createState()
    {
        return new _DrawerState();
    }

    class _DrawerState : State<DrawerWidget>
    {
        #region 参数
        readonly GlobalKey<ScaffoldState> _scaffoldKey = GlobalKey<ScaffoldState>.key();
        #endregion

        #region 重写
        public override Widget build(BuildContext context)
        {
            return new Scaffold(
                key: _scaffoldKey,
                drawer: new AppDrawer(),
                appBar: new AppBar(
                    title: new Text("Title")
                ),
                body: new ListView(
                    children: new List<Widget>()
                    {
                        new ListTile(
                            title: new Text("Body")
                        ),
                        new ListTile(
                            title: new RaisedButton(
                                child: new Text("Open Drawer"),
                                onPressed: () =>
                                {
                                    _scaffoldKey.currentState.openDrawer();
                                }
                            )
                        )
                    }
                )
            );
        }
        #endregion

        #region 函数

        class AppDrawer : StatefulWidget
        {
            public override State createState()
            {
                return new _AppDrawerState();
            }
        }

        class _AppDrawerState : State<AppDrawer>
        {
            public override Widget build(BuildContext context)
            {
                return new Drawer(
                    child: new ListView(
                        children: new List<Widget>()
                        {
                        new DrawerHeader(
                            child: new Text("Header")
                        ),
                        new ListTile(
                            title: new Text("Item 1")
                        )
                        }
                    )
                );
            }
        }
        #endregion
    }
}