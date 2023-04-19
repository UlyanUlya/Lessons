namespace Lesson2
{
    public class Cars : IManagementCars
    {
        public string GetCarAge() => "1";

        public string GetCarEngine() => "3.0L";

        public string GetCarName() => "Ford Escape";
    }

    interface IManagementCars
    {
        string GetCarName();
        string GetCarEngine();
        string GetCarAge();
    }
}
