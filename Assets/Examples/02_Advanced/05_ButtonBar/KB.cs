using Unity.UIWidgets.widgets;
using Unity.UIWidgets.material;
using Unity.UIWidgets.ui;
using Color = Unity.UIWidgets.ui.Color;

public class KB : StatefulWidget
{
    public override State createState()
    {
        return new TBState();
    }

    class TBState : State<KB> 
    {
        public override Widget build(BuildContext context) 
        {
            return new MaterialApp(
                home: new Scaffold(
                    appBar: new AppBar(
                        title: new Text("课表"),
                        backgroundColor: Color.fromARGB(255, 119, 136, 213), //设置appbar背景颜色
                        centerTitle: true //设置标题是否局中
                    ),
                    body: new Center(
                        child: new Text("课表")
                    )
                )
            );
        }
    }
}
