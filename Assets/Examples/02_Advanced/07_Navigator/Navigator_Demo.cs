using System.Collections.Generic;
using UnityEngine;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.service;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using Unity.UIWidgets.foundation;
using UIWidgets.Runtime.material;
using Material = Unity.UIWidgets.material.Material;
using Color = Unity.UIWidgets.ui.Color;

public class Navigator_Demo : UIWidgetsPanel
{
    protected override Widget createWidget()
    {
        return new MaterialApp(
            title: "Navigation Basics",
            home: new FirstScreen()
        );
    }

    class FirstScreen : StatelessWidget
    {
        public override Widget build(BuildContext context) 
        {
            return new Scaffold(
                appBar: new AppBar(
                    title: new Text("First Screen")
                    ),
                body: new Center(
                    child: new RaisedButton(
                        child: new Text("Launch new screen"),
                        onPressed: () => 
                        {
                            Navigator.push(
                                context,
                                new MaterialPageRoute(
                                    builder: (context1) => new SecondScreen()
                                )
                            );
                        }
                    )
                )
            );
        }
    }

    class SecondScreen : StatelessWidget
    {
        public override Widget build(BuildContext context) 
        {
            return new Scaffold(
                appBar: new AppBar(
                    title: new Text("Second Screen")
                    ),
                body: new Center(
                    child: new RaisedButton(
                        onPressed: () => 
                        {
                            Navigator.pop(context);
                        },
                        child: new Text("Go back!")
                    )
                )
            );
        }
    }
}
