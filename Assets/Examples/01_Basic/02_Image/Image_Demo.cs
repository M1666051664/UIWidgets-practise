using System.Collections.Generic;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

public class Image_Demo : UIWidgetsPanel
{
    protected override Widget createWidget()
    {
        return new ImageWidget();
    }
}

public class ImageWidget : StatelessWidget
{
    public override Widget build(BuildContext context)
    {
        return new Column(
            children: new List<Widget>
            {
                new Container(
                    width:300f,
                    height:300f,
                    decoration:new BoxDecoration(
                        image:new DecorationImage(
                            image:new AssetImage(
                                "unitychan"
                            )
                        )
                    )
                ),
                new Text("UnityChan: Hello Guys!",
                    style:new TextStyle(
                        color: Color.white,
                        fontSize:32.0f
                    )
                )
            }
        );
    }
}
