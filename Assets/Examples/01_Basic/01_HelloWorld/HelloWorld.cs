using UnityEngine;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using Unity.UIWidgets.foundation;
using Unity.UIWidgets.material;
using Color = Unity.UIWidgets.ui.Color;

public class HelloWorld : StatefulWidget
{
    // 构造方法
    public HelloWorld(Key key = null, VoidCallback onSendFeedback = null) : base(key: key)
    {
        this.onSendFeedback = onSendFeedback;
    }

    public readonly VoidCallback onSendFeedback;

    public override State createState()
    {
        return new _HelloWorldState();
    }

    // 实现方法
    class _HelloWorldState : State<HelloWorld>
    {
        #region 参数

        #endregion

        #region 重写
        public override void dispose()
        {
            //Debug.Log("dispose");
            base.dispose();
        }

        public override void initState()
        {
            //Debug.Log("initState");
            base.initState();
        }

        // 绘制方法
        public override Widget build(BuildContext context)
        {
            //Debug.Log("build");
            return new MaterialApp(
                title: "Welcome to Flutter", //只对android有效
                home: new Scaffold(
                    appBar: new AppBar(
                        //bottom: new PreferredSize(preferredSize: new Size(500, 100)),
                        bottom: new PreferredSize(preferredSize: Size.fromHeight(0)), //默认高度
                        title: new Text(
                            data: "Welcome to Flutter",
                            textAlign: TextAlign.center,
                            style: new TextStyle(
                                color: Color.white,
                                fontSize: 32.0f
                            )
                        ),
                        centerTitle: true,
                        brightness: Unity.UIWidgets.service.Brightness.dark
                    ),
                    body: new Center(
                        child: new Text("hello world")
                    )
                )
            );
        }
        #endregion

        #region 函数

        #endregion
    }
}
