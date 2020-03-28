using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.material;
using Unity.UIWidgets.widgets;
using Unity.UIWidgets.painting;
using Color = Unity.UIWidgets.ui.Color;

public class Dashboard : StatefulWidget
{
    public override State createState()
    {
        return new _DashboardState();
    }

    class _DashboardState : State<Dashboard>
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
                    bottom: new PreferredSize(preferredSize: Size.fromHeight(0)), //默认高度
                    title: new Text(
                        "Dashboard",
                        style: new TextStyle(
                            color: Colors.black,
                            fontSize: 32
                        )
                    ),
                    backgroundColor: Colors.white,
                    elevation: 0 //阴影
                )
            );
        }
    }
}
