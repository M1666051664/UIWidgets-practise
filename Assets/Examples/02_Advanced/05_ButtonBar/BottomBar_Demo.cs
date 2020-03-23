using System.Collections.Generic;
using System;
using UnityEngine;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using Unity.UIWidgets.scheduler;
using Unity.UIWidgets.foundation;
using Unity.UIWidgets.rendering;
using Material = Unity.UIWidgets.material.Material;

public class BottomBar_Demo : UIWidgetsPanel
{
    protected override void OnEnable()
    {
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

    class _BottomBarState : SingleTickerProviderStateMixin<BottomBar>
    {
        TabController controller;

        public override void initState()
        {
            base.initState();

            controller = new TabController(
                length: 3,
                vsync: this
            );
        }

        public override Widget build(BuildContext context)
        {
            return new MaterialApp(
                home: new Scaffold(
                    body: new TabBarView(
                        controller: controller,
                        children: new List<Widget>()
                        {
                            new Today(),
                            new KB(),
                            new Playground()
                        }
                    ),
                    bottomNavigationBar: new Material(
                        color: Colors.white,
                        child: new TabBar(
                            controller: controller,
                            labelColor: Colors.deepPurpleAccent,
                            unselectedLabelColor: Colors.black26,
                            tabs: new List<Widget>()
                            {
                                new Tab(
                                    text: "今日",
                                    icon: new Icon(Icons.brightness_5)
                                ),
                                new Tab(
                                    text: "课表",
                                    icon: new Icon(Icons.map)
                                ),
                                new Tab(
                                    text: "操场",
                                    icon: new Icon(Icons.directions_run)
                                )
                            }
                        )
                    )
                )
            );
        }
    }
}