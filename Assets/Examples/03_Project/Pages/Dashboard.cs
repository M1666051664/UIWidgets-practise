using System.Collections;
using System.Collections.Generic;
using Unity.UIWidgets.material;
using Unity.UIWidgets.widgets;
using UnityEngine;

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
                    title: new Text("Dashboard")
                )
            );
        }
    }
}
