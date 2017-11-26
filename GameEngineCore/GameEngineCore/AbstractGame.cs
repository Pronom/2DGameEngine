using GameEngineCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngineCore.AppStart;
using static GameEngineCore.Program;
using System.Windows;
using System.Windows.Shapes;
using System.Reflection;
using System.Windows.Controls;
using System.Windows.Input;

namespace GameEngineCore
{
    public abstract class AbstractGame 
    {
        public delegate void BreakGameLoop();
        
        public static BreakGameLoop OnBreakGameLoop;
        
        public List<Shape> ShapeList = new List<Shape>();
        public abstract void Init();

        public abstract void Update();

        public abstract void Draw();

        public abstract void Finish();

        

        public AbstractGame()
        {
            Init();
            FillShapeList();
            initShapes();
            Games.GameList.Add(this);
        }

        protected void FillShapeList()
        {
            foreach (PropertyInfo item in this.GetType().GetProperties())
            {
                
                    Shape addShape = (Shape)item.GetValue(this);
                
                //if (isShapeType(item.GetType()))
                //{
                //    Type t = item.GetType();
                //    addShape = item.GetValue(this) as Shape;
                //    ShapeList.Add(addShape);
                //}

                
                ShapeList.Add(addShape);
            }
        }

        protected bool isShapeType(Type type)
        {
            if (type == typeof(Shape))
            {
                return true;
            }

            if (type.BaseType == typeof(Shape))
            {
                return true;
            }

            while (type.BaseType != null)
            {
                isShapeType(type.BaseType);
            }

            return false;
        }

        protected void initShapes()
        {
            foreach (var item in ShapeList)
            {
                Injector.windowCanvas.Children.Add(item);
            }
        }


    }
}
