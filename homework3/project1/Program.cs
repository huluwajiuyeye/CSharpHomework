using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Shape
{

}
public class Square:Shape
{
    private int mySide;
    public Square()
    {
        string a = "";
        Console.WriteLine("请输入正方体边长");
        a = Console.ReadLine();
        mySide = Int32.Parse(a);
        Console.WriteLine("正方形面积为" + mySide * mySide);
    }

}
public class Circle : Shape
{
    private int myRadius;
    public Circle()
    {
        string a = "";
        Console.WriteLine("请输入圆的半径");
        a = Console.ReadLine();
        myRadius= Int32.Parse(a);
        Console.WriteLine("圆形面积为" + myRadius * myRadius*3.14);
    }

}
public class Rectangle : Shape
{
    private int myWid,myHei;
    public Rectangle()
    {
        string a = ""; string b = "";
        Console.WriteLine("请输入矩形的长和宽");
        a = Console.ReadLine();
        myWid = Int32.Parse(a);
        b = Console.ReadLine();
        myHei = Int32.Parse(b);
        Console.WriteLine("长方形面积为" + myWid * myHei);
    }

}
public class Sanjiao : Shape
{
    private int myDi,myGao;
    public Sanjiao()
    {
        string a = ""; string b = "";
        Console.WriteLine("请输入三角形的底和高");
        a = Console.ReadLine();
        myDi = Int32.Parse(a);
        b = Console.ReadLine();
        myGao = Int32.Parse(b);
        Console.WriteLine("三角形面积为" + myDi * myGao/2);
    }

}


public class OperationFactory
{

    public static Shape getShape()
    {
        string shape = "";
        Console.WriteLine("请输入：  1：正方形 2：圆形 3：矩形 4：三角形");
        shape = Console.ReadLine();
        switch (shape)
        {
            case "1":
                new Square();break;
            case "2":  
                new Circle(); break;
            case "3":
                
                new Rectangle();break;
            case "4":
      
                new Sanjiao(); break;
            default: break;
        }
        return null;
    }
}

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            OperationFactory.getShape();
        }
    }
}
