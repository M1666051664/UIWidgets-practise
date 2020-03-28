using System.Collections.Generic;
using UnityEngine;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using Unity.UIWidgets.service;
using Unity.UIWidgets.foundation;
using Unity.UIWidgets.material;
using Color = Unity.UIWidgets.ui.Color;
using Unity.UIWidgets.rendering;

public class Home : StatefulWidget
{
    public override State createState()
    {
        return new _HomeState();
    }

    class _HomeState : State<Home>
    {
        int currentTab = 0; // to keep track of active tab index
        public List<Widget> screens = new List<Widget>()
        {
            new Dashboard(),
            new Chat(),
            new Profile(),
            new Settings()
        }; // to store nested tabs
        PageStorageBucket bucket = new PageStorageBucket();
        Widget currentScreen = new Dashboard(); // Our first view in viewport

        public override void dispose()
        {
            base.dispose();
        }

        public override void initState()
        {
            base.initState();
        }

        public override Widget build(BuildContext context)
        {
            return new Scaffold(
                body: new PageStorage(
                    child: currentScreen,
                    bucket: bucket
                ),
                floatingActionButton: new FloatingActionButton(
                    child: new Icon(Icons.add, size: 30),
                    //child: new Unity.UIWidgets.widgets.Image(image: new AssetImage("unitychan")),
                    backgroundColor: new Color(0xFF7554E5), //0xff374ABE
                    onPressed: () => 
                    {
                        Debug.Log("ActionButton"); 
                    }
                ),
                floatingActionButtonLocation: FloatingActionButtonLocation.centerDocked,
                bottomNavigationBar: new BottomAppBar(
                    //shape: new CircularNotchedRectangle(), //底板形状
                    //color: Colors.blue,
                    notchMargin: 10,
                    child: new Container(
                        height: 60,
                        child: new Row(
                            mainAxisAlignment: MainAxisAlignment.spaceBetween, //有中央按钮
                            children: new List<Widget>()
                            {
                                // Left Tab bar icons
                                new Row(
                                    crossAxisAlignment: CrossAxisAlignment.start,
                                    children: new List<Widget>()
                                    {
                                        new MaterialButton(
                                            minWidth: 100,
                                            onPressed: () =>
                                            {
                                                setState(() =>
                                                {
                                                    currentScreen = new Dashboard(); // if user taps on this dashboard tab will be active
                                                    currentTab = 0;
                                                });
                                            },
                                            child: new Icon(
                                                Icons.dashboard,
                                                color: currentTab == 0 ? Colors.black : Colors.grey
                                            )
                                        ),
                                        new MaterialButton(
                                            minWidth: 100,
                                            onPressed: () =>
                                            {
                                                setState(() =>
                                                {
                                                    currentScreen = new Chat(); // if user taps on this dashboard tab will be active
                                                    currentTab = 1;
                                                });
                                            },
                                            child: new Icon(
                                                Icons.chat,
                                                color: currentTab == 1 ? Colors.blue : Colors.grey
                                            )
                                        )
                                    }
                                ),
                                // Right Tab bar icons
                                new Row(
                                    crossAxisAlignment: CrossAxisAlignment.start,
                                    children: new List<Widget>()
                                    {
                                        new MaterialButton(
                                            minWidth: 100,
                                            onPressed: () =>
                                            {
                                                setState(() =>
                                                {
                                                    currentScreen = new Profile(); // if user taps on this dashboard tab will be active
                                                    currentTab = 2;
                                                });
                                            },
                                            child: new Icon(
                                                Icons.panorama,
                                                color: currentTab == 2 ? Colors.blue : Colors.grey
                                            )
                                        ),
                                        new MaterialButton(
                                            minWidth: 100,
                                            onPressed: () =>
                                            {
                                                setState(() =>
                                                {
                                                    currentScreen = new Settings(); // if user taps on this dashboard tab will be active
                                                    currentTab = 3;
                                                });
                                            },
                                            child: new Icon(
                                                Icons.settings,
                                                color: currentTab == 3 ? Colors.blue : Colors.grey
                                            )
                                        )
                                    }
                                )
                            }
                        )
                    )
                )
            );
        }
    }
}