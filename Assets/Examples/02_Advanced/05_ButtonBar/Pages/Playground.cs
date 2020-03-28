using Unity.UIWidgets.widgets;
using Unity.UIWidgets.material;
using Unity.UIWidgets.ui;
using Color = Unity.UIWidgets.ui.Color;

public class Playground : StatefulWidget
{
    public override State createState()
    {
        return new PlaygroundState();
    }

    class PlaygroundState : State<Playground> 
    {
        public override Widget build(BuildContext context) 
        {
            return new MaterialApp(
                home: new Scaffold(
                    appBar: new AppBar(
                        title: new Text("操场"),
                        backgroundColor: Color.fromARGB(255, 119, 136, 213), //设置appbar背景颜色
                        centerTitle: true //设置标题是否局中
                    ),
                    body: new Center(
                        child: new Text("操场")
                    )
                )
            );
        }
    }
}
