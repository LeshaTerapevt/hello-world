namespace HelloWorld.Core;

public sealed class InMemoryConfigurationStore<T>(T initialValue) : IConfigurationStore<T>
{
    private T _value = initialValue;

    public T Load() => _value;

    public void Save(T config)
    {
        _value = config;
    }
}
