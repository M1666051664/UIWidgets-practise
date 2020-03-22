using System.Collections.Generic;
using UnityEngine;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.service;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UIWidgets.Runtime.material;

public class TextField_Demo : UIWidgetsPanel
{
    protected override Widget createWidget()
    {
        return new TextFieldWidget();
    }
}

public class TextFieldWidget : StatelessWidget
{
    public override Widget build(BuildContext context)
    {
        //return new MaterialApp(
        //    home: new Scaffold(
        //        appBar: new AppBar(
        //            title: new Text("文本输入")
        //        ),
        //        body: new Center(
        //            child: new Column(
        //                children: new List<Widget>()
        //                {
        //                    new Text("简单文本输入框", style: new TextStyle(fontSize: 20.0f)),
        //                    new TextField(keyboardType: TextInputType.text),  //指定输入方式为文本输入
        //                    new TextField(keyboardType: TextInputType.number) //指定唤起软键盘时默认显示数字键盘
        //                }
        //            )
        //        )
        //    )
        //);


        //return new GestureDetector(
        //    onTap: () => {
        //        Debug.Log("触摸收起键盘");
        //        //FocusScope.of(context).requestFocus(new FocusNode());
        //    },
        //    child: new Scaffold(
        //        appBar: new AppBar(
        //            title: new Text("文本输入")
        //        ),
        //        body: new Center(
        //            child: new Padding(
        //                padding: EdgeInsets.all(10.0f),
        //                child: new Column(
        //                    mainAxisAlignment: MainAxisAlignment.center,
        //                    children: new List<Widget>() {
        //                        new Text(
        //                            "$_counter",
        //                            style: Theme.of(context).textTheme.display1
        //                        ),
        //                        new TextField(
        //                            decoration: new InputDecoration(
        //                                hintText: "用户名或邮箱",
        //                                labelText: "用户名",
        //                                prefixIcon: new Icon(Icons.person)
        //                            )
        //                        ),
        //                        new TextField(
        //                            decoration: new InputDecoration(
        //                                hintText: "密码",
        //                                labelText: "密码",
        //                                prefixIcon: new Icon(Icons.lock_icon)
        //                            ),
        //                            obscureText: true
        //                        )
        //                    }
        //                )
        //            )
        //        ),
        //        floatingActionButton: new FloatingActionButton(
        //            onPressed: () => { },
        //            tooltip: "Increment",
        //            child: new Icon(Icons.add)
        //        ) // This trailing comma makes auto-formatting nicer for build methods.
        //    )
        //);


        return new MaterialApp(
            home: new Scaffold(
                body: new Container(
                    height: 500.0f,
                    child: new GestureDetector(
                        onTap: () =>
                        {
                            Debug.Log("触摸收起键盘");
                            FocusScope.of(context).requestFocus(new FocusNode());
                        },
                        child: new Container(
                            color: Colors.white,
                            child: new Column(
                                mainAxisAlignment: MainAxisAlignment.center,
                                crossAxisAlignment: CrossAxisAlignment.center,
                                children: new List<Widget>()
                                {
                                    new TextField(),
                                    new Text("Test")
                                }
                            )
                        )
                    )
                )
            )
        );
    }
}
