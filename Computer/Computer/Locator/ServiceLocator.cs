using System;
using System.Collections.Generic;
using Computer.Data;

namespace Computer.Locator
{
    public class ServiceLocator : IServiceLocator
    {
        private readonly Dictionary<object, object> _services;

        public ServiceLocator()
        {
            _services = new Dictionary<object, object>();
            _services.Add(typeof(IComputerElementData), new ComputerElementsData());
            _services.Add(typeof(IComputerSystem), new ComputerSystem(GetService<IComputerElementData>().ComputerElements));
        }

        public T GetService<T>()
        {
            try
            {
                return (T)_services[typeof(T)];
            }
            catch (KeyNotFoundException)
            {
                throw new ApplicationException("Сервір не зареєстрований!");
            }
        }
    }
}