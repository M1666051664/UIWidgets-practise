using UnityEngine;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using Unity.UIWidgets.foundation;
using Unity.UIWidgets.material;
using Color = Unity.UIWidgets.ui.Color;

public class LoginTest : UIWidgetsPanel
{
    protected override Widget createWidget()
    {
        return new Flutter.Login();
    }

    protected override void OnEnable()
    {
        base.OnEnable();
    }
}

namespace Flutter
{
    public class Login : StatefulWidget
    {
        // 构造方法
        public Login(Key key = null, VoidCallback onSendFeedback = null) : base(key: key)
        {
            this.onSendFeedback = onSendFeedback;
        }

        public readonly VoidCallback onSendFeedback;

        public override State createState()
        {
            return new LoginState();
        }

        // 实现方法
        class LoginState : State<Login>
        {
            #region 参数
            #endregion

            #region 重写
            public override void dispose()
            {
                base.dispose();
            }

            public override void initState()
            {
                base.initState();
            }

            // 绘制方法
            public override Widget build(BuildContext context)
            {
                return new MaterialApp(
                    title: "Flutter Login Demo",
                    theme: new ThemeData(
                        primarySwatch: Colors.blue
                    ), 
                    home: new LoginSignupPage()
                );
            }
            #endregion

            #region 函数

            #endregion
        }
    }
}