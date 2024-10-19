namespace AbstractFactoryDesignPattern.Example_2.Concrete_Class
{
    internal class NokiaPixel : ISmartPhone
    {
        public string GetModelDetails()
        {
            return "Model : Nokia Pixel \n RAM: 3GB\n Camera: 8MP";
        }
    }
}