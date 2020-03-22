using System.Collections.Generic;
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
        readonly GlobalKey<ScaffoldState> _scaffoldKey = GlobalKey<ScaffoldState>.key();

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
                                    _scaffoldKey.currentState.openDrawer(); //打开抽屉
                                }
                            )
                        )
                    }
                )
            );
        }
    }
}
