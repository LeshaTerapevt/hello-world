namespace HelloWorld.Core;

public interface IConfigurationStore<T>
{
    T Load();
    void Save(T config);
}
