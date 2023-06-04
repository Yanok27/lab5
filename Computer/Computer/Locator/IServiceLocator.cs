namespace Computer.Locator
{
    public interface IServiceLocator
    {
        T GetService<T>();
    }
}