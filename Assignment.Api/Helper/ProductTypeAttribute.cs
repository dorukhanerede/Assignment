namespace Assignment.Api.Helper
{
    public class ProductTypeAttribute : Attribute
    {
        public double width { get; private set; }

        public int stackSize { get; private set; }

        public ProductTypeAttribute(double _width, int _stackSize)
        {
            width = _width;
            stackSize = _stackSize;
        }
    }
}