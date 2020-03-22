using System;
using System.Collections.Generic;
using UnityEngine;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using Unity.UIWidgets.foundation;
using Unity.UIWidgets.material;
using Color = Unity.UIWidgets.ui.Color;
using UIWidgetsGallery.gallery;
using UIWidgets.Runtime.material;
using Unity.UIWidgets.service;

namespace Flutter
{
    //public class LoginSignupPage : StatelessWidget
    //{
    //    public override Widget build(BuildContext context)
    //    {
    //        return new Scaffold(
    //            appBar: new AppBar(
    //                title: new Text("Flutter login demo")
    //            ),
    //            body: new Container(
    //                child: new Text("Hello World")
    //            )
    //        );
    //    }
    //}

    public class LoginSignupPage : StatefulWidget
    {
        public override State createState()
        {
            return new _LoginSignupPageState();
        }

        // 实现方法
        class _LoginSignupPageState : State<LoginSignupPage>
        {
            #region 参数
            readonly GlobalKey<FormState> _formKey = GlobalKey<FormState>.key();
            public bool _isLoading;
            public bool _isLoginForm;
            public string _email;
            public string _password;
            public string _errorMessage;
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
                return new Scaffold(
                    appBar: new AppBar(
                      title: new Text("Flutter login demo")
                    ),
                    body: new Stack(
                        children: new List<Widget>
                        {
                            showForm(),
                            showCircularProgress()
                        }
                    ));
            }
            #endregion

            #region 函数

            Widget showForm()
            {
                return new Container(
                    padding: EdgeInsets.all(16.0f),
                    child: new Form(
                        key: _formKey,
                        child: new ListView(
                            shrinkWrap: true,
                            children: new List<Widget>
                            {
                                showLogo(),
                                showEmailInput(),
                                showPasswordInput(),
                                showPrimaryButton(),
                                showSecondaryButton(),
                                showErrorMessage()
                            }
                        )
                    )
                );
            }

            Widget showCircularProgress()
            {
                if (_isLoading)
                {
                    return new Center(child: new CircularProgressIndicator());
                }
                return new Container(
                    height: 0.0f,
                    width: 0.0f
                );
            }

            Widget showLogo()
            {
                return new Hero(
                    tag: "hero",
                    child: new Padding(
                        padding: EdgeInsets.fromLTRB(0.0f, 70.0f, 0.0f, 0.0f),
                        child: new CircleAvatar(
                            //child: new Image.asset('assets/flutter-icon.png'),
                            child: new Unity.UIWidgets.widgets.Image(image: new AssetImage("unitychan")),
                            backgroundColor: Colors.transparent,
                            radius: 48.0f
                        )
                    )
                );
            }

            Widget showEmailInput()
            {
                return new Padding(
                    padding: EdgeInsets.fromLTRB(0.0f, 100.0f, 0.0f, 0.0f),
                    child: new TextFormField(
                        maxLines: 1,
                        keyboardType: TextInputType.emailAddress,
                        autofocus: false,
                        decoration: new InputDecoration(
                            hintText: "Email",
                            icon: new Icon(
                                Icons.mail,
                                color: Colors.grey
                            )
                        ),
                        validator: new FormFieldValidator<string>((value) => value.isEmpty() ? "Email can\'t be empty" : null),
                        onSaved: new FormFieldSetter<string>((value) => _email = value.Trim())
                    )
                );
            }

            Widget showPasswordInput()
            {
                return new Padding(
                    padding: EdgeInsets.fromLTRB(0.0f, 15.0f, 0.0f, 0.0f),
                    child: new TextFormField(
                        maxLines: 1,
                        obscureText: true,
                        autofocus: false,
                        decoration: new InputDecoration(
                            hintText: "Password",
                            icon: new Icon(
                                Icons.lock_icon,
                                color: Colors.grey
                            )
                        ),
                        validator: (value) => value.isEmpty() ? "Password can\'t be empty" : null,
                        onSaved: (value) => _password = value.Trim()
                    )
                );
            }

            Widget showPrimaryButton()
            {
                return new Padding(
                    padding: EdgeInsets.fromLTRB(0.0f, 45.0f, 0.0f, 0.0f),
                    child: new SizedBox(
                        height: 40.0f,
                        child: new RaisedButton(
                            elevation: 5.0f,
                            shape: new RoundedRectangleBorder(
                                borderRadius: BorderRadius.circular(30.0f)),
                            color: Colors.blue,
                            child: new Text(_isLoginForm ? "Login" : "Create account",
                            style: new TextStyle(fontSize: 20.0f, color: Colors.white)),
                            onPressed: validateAndSubmit
                        )
                    ));
            }
            void validateAndSubmit()
            {
                Debug.Log("校验输入");
            }

            Widget showSecondaryButton()
            {
                return new FlatButton(
                    child: new Text(
                        _isLoginForm ? "Create an account" : "Have an account? Sign in",
                        style: new TextStyle(fontSize: 18.0f, fontWeight: FontWeight.w300)
                    ),
                    onPressed: toggleFormMode
                );
            }
            void toggleFormMode()
            {
                Debug.Log("toggleFormMode");
                //resetForm();
                setState(() =>
                {
                    _isLoginForm = !_isLoginForm;
                });
            }

            Widget showErrorMessage()
            {
                if (string.IsNullOrEmpty(_errorMessage))
                {
                    return new Text(
                        _errorMessage,
                        style: new TextStyle(
                            fontSize: 13.0f,
                            color: Colors.red,
                            height: 1.0f,
                            fontWeight: FontWeight.w300
                        )
                    );
                }
                else
                {
                    return new Container(
                        height: 0.0f
                    );
                }
            }

            #endregion
        }

    }
}
