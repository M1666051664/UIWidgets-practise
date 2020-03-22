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
using Material = Unity.UIWidgets.material.Material;

public class Emoji_Demo : UIWidgetsPanel
{
    protected override Widget createWidget()
    {
        return new Emoji();
    }
}

public class Emoji : StatelessWidget
{
    public override Widget build(BuildContext context)
    {
        return new Center(
            child: new RichText(
                text: new TextSpan(
                    children: new List<TextSpan>()
                    {
                        new TextSpan(
                            text: "Hello"  // non-emoji characters
                        ),
                        new TextSpan(
                            text: "🧭 🌈 \u2763 \u2764", // emoji characters
                            style: new TextStyle(
                                fontFamily: "EmojiOne",
                                fontSize: 32
                            )
                        )
                    }
                )
            )
        );
    }
}