using System.Collections;
using System.Collections.Generic;
using Unity.UIWidgets.material;
using Unity.UIWidgets.widgets;
using UnityEngine;

public class Profile : StatefulWidget
{
    public override State createState()
    {
        return new _ProfileState();
    }

    class _ProfileState : State<Profile>
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
                    title: new Text("Profile")
                )
            );
        }
    }
}
