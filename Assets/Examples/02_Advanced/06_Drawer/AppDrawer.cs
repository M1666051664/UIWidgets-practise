using System.Collections.Generic;
using Unity.UIWidgets.material;
using Unity.UIWidgets.widgets;

public class AppDrawer : StatefulWidget
{
    public override State createState()
    {
        return new _AppDrawerState();
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
}
