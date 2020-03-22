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
        //return new TextFieldWidget(); //无状态
        return new FocusTestRoute(); //保存状态
    }
}

public class TextFieldWidget : StatelessWidget
{
    public override Widget build(BuildContext context)
    {
        return new MaterialApp(
            home: new Scaffold(
                appBar: new AppBar(
                    title: new Text("文本输入")
                ),
                body: new Center(
                    child: new Column(
                        children: new List<Widget>()
                        {
                            new Text("简单文本输入框", style: new TextStyle(fontSize: 20.0f)),
                            new TextField(keyboardType: TextInputType.text),  //指定输入方式为文本输入
                            new TextField(keyboardType: TextInputType.number) //指定唤起软键盘时默认显示数字键盘
                        }
                    )
                )
            )
        );
    }
}

// TextField 保存状态需要使用 StatefulWidget
public class FocusTestRoute : StatefulWidget
{
    public override State createState()
    {
        return new _FocusTestRouteState();
    }

    public class _FocusTestRouteState : State<FocusTestRoute>
    {
        FocusNode focusNodeUserName = new FocusNode();
        FocusNode focusNodePassword = new FocusNode();
        FocusScopeNode currentFocus;

        public override void dispose()
        {
            base.dispose();
        }

        public override void initState()
        {
            base.dispose();
        }

        public override Widget build(BuildContext context)
        {
            return new MaterialApp(
                home: new Scaffold(
                    resizeToAvoidBottomPadding: false, //输入框抵住键盘 内容不随键盘滚动
                    body: new Container(
                        height: 500.0f,
                        child: new GestureDetector(
                            onTap: () =>
                            {
                                Debug.Log("触摸收起键盘");
                                focusNodeUserName.unfocus();
                                focusNodePassword.unfocus();
                                //如果没有关联'focusnode'要关闭键盘可以用: FocusScope.of(context).requestFocus(FocusNode());
                            },
                            child: new Container(
                                color: Colors.white,
                                child: new Column(
                                    mainAxisAlignment: MainAxisAlignment.center, //垂直
                                    crossAxisAlignment: CrossAxisAlignment.start, //水平
                                    children: new List<Widget>()
                                    {
                                        new Text(
                                            data: "用户名"
                                            //textAlign: TextAlign.left //由上层控制，这里设置无效
                                        ),
                                        new TextField(
                                            autofocus: true,
                                            //decoration: new InputDecoration(labelText: "用户名"), //placeholder文字上飘
                                            //textInputAction: TextInputAction.done, //TODO: 没用？
                                            focusNode: focusNodeUserName,
                                            onSubmitted: (value) =>
                                            {
                                                Debug.Log($"onSubmitted value={value}");
                                            }
                                        ),
                                        new Container(
                                            child: new Text("密码", textAlign: TextAlign.left)
                                        ),
                                        new TextField(
                                            autofocus: true,
                                            focusNode: focusNodePassword, //关联focusNodePassword
                                            onSubmitted: (value) =>
                                            {
                                                Debug.Log($"onSubmitted value={value}");
                                            }
                                        )
                                    }
                                )
                            )
                        )
                    )
                )
            );
        }
    }
}
