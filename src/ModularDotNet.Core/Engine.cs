using System;
using System.Collections.Generic;
using System.Linq;
using DryIoc;
using ModularDotNet.Core.Interfaces;
using ModularDotNet.Core.Managers;

namespace ModularDotNet.Core
{
    public static class Engine
    {
        #region Properties

        private static IContainer _Container { get; set; }

        public static ICurrent Current => Resolve<ICurrent>();

        #endregion

        #region Constructor

        static Engine()
        {
            _Container = new Container();
        }

        #endregion

        #region Methods

        public static void Start()
        {
            
        }

        public static void End()
        {
            LogManager.End();
        }

        public static string DIDiagnostics()
        {
            return string.Join("\r\n", _Container.GetServiceRegistrations().Select(x => $"[{x.OptionalServiceKey}]\r\n{x.ServiceType.FullName}\r\n{x.Factory.ImplementationType?.FullName}"));
        }

        public static IContainer GetContainer()
        {
            return _Container;
        }

        public static object MustResolve(Type serviceType)
        {
            return _Container.Resolve(serviceType);
        }

        public static object MustResolve(Type serviceType,
            string serviceKey)
        {
            return _Container.Resolve(serviceType, serviceKey);
        }

        public static T MustResolve<T>()
        {
            return _Container.Resolve<T>();
        }

        public static T MustResolve<T>(string serviceKey)
        {
            return _Container.Resolve<T>(serviceKey);
        }

        public static object Resolve(Type serviceType)
        {
            return _Container.Resolve(serviceType, IfUnresolved.ReturnDefault);
        }

        public static object Resolve(Type serviceType,
            string serviceKey)
        {
            return _Container.Resolve(serviceType, serviceKey, IfUnresolved.ReturnDefault);
        }

        public static T Resolve<T>()
        {
            return _Container.Resolve<T>(IfUnresolved.ReturnDefault);
        }

        public static T Resolve<T>(string serviceKey)
        {
            return _Container.Resolve<T>(serviceKey, IfUnresolved.ReturnDefault);
        }

        public static IEnumerable<object> ResolveMany(Type serviceType)
        {
            return _Container.ResolveMany(serviceType);
        }

        public static IEnumerable<object> ResolveMany(Type serviceType,
            string serviceKey)
        {
            return _Container.ResolveMany(serviceType, serviceKey: serviceKey);
        }

        public static IEnumerable<T> ResolveMany<T>()
        {
            return _Container.ResolveMany<T>();
        }

        public static IEnumerable<T> ResolveMany<T>(string serviceKey)
        {
            return _Container.ResolveMany<T>(serviceKey: serviceKey);
        }

        #endregion
    }
}
