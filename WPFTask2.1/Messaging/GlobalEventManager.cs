using System;
using WPFTask2._1.Models;

namespace WPFTask2._1.Messaging
{
    public class GlobalEventManager
    {
        public event Action<Shape> ShapeCreated;

        private static GlobalEventManager _instance = null;

        private GlobalEventManager()
        {

        }

        public static GlobalEventManager GetInstance()
        {
            if (_instance == null)
                _instance = new GlobalEventManager();

            return _instance;
        }

        public void OnShapeCreated(Shape shape)
        {
            ShapeCreated?.Invoke(shape);
        }
    }
}
