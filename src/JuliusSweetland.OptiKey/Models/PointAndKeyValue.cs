using System.Windows;

namespace JuliusSweetland.OptiKey.Models
{
    public struct PointAndKeyValue
    {
        public PointAndKeyValue(Point point, KeyValue? keyValue)
            : this()
        {
            Point = point;
            KeyValue = keyValue;
        }

        public Point Point { get; }
        public KeyValue? KeyValue { get; }

        public bool StringIsLetter => KeyValue?.StringIsLetter ?? false;

        public string String => KeyValue?.String;

        public override string ToString() => $"({Point.X},{Point.Y})='{KeyValue}'";
    }
}
