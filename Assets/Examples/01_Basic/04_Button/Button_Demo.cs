using System.Collections.Generic;
using UnityEngine;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using Color = Unity.UIWidgets.ui.Color;

public class Button_Demo : UIWidgetsPanel
{
    protected override Widget createWidget()
    {
        return new ButtonWidget();
    }
}

public class ButtonWidget : StatelessWidget
{
    public override Widget build(BuildContext context)
    {
        //return RaisedButtonWidget();

        return new Column(
            mainAxisAlignment: MainAxisAlignment.center,
            crossAxisAlignment: CrossAxisAlignment.center,
            children: new List<Widget>
            {
                new Text("渐变按钮",
                    style:new TextStyle(
                        color: Color.white,
                        fontSize:32.0f
                    )
                ),
                VerticalPadding(20f),
                RaisedButtonWidget("Login", new Size(300, 50)),
                VerticalPadding(20f),
                RaisedButtonWidget("Logout", new Size(300, 50)),
                VerticalPadding(20f),
                RaisedButtonWidget("Register", new Size(300, 50)),
                VerticalPadding(20f),
                RaisedButtonWidget("Forget", new Size(300, 50))
            }
        );
    }

    // 垂直间距
    Widget VerticalPadding(float value)
    {
        return new Container(height: value);
    }

    Widget RaisedButtonWidget(string text = "", Size size = null)
    {
        return new Container(
            width: size.width,
            height: size.height,
            child: new RaisedButton(
                onPressed: () => {
                    Debug.Log($"onPressed: {text}");
                },
                shape: new RoundedRectangleBorder(borderRadius: BorderRadius.circular(20.0f)), //外层圆角
                padding: EdgeInsets.all(0.0f), //收缩像素
                child: new Ink(
                    decoration: new BoxDecoration(
                        gradient: new LinearGradient(
                            colors: new List<Color>()
                            {
                                new Color(0xff374ABE),
                                new Color(0xff64B6FF)
                            },
                            begin: Alignment.centerLeft,
                            end: Alignment.centerRight
                        ),
                        borderRadius: BorderRadius.circular(10.0f) //内层圆角
                    ),
                    child: new Container(
                        constraints: new BoxConstraints(maxWidth: size.width, minHeight: size.height),
                        alignment: Alignment.center,
                        child: new Text(
                            data: text,
                            textAlign: TextAlign.center,
                            style: new TextStyle(
                                color: Colors.white
                            )
                        )
                    )
                )
            )
        );
    }
}
