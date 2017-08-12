using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Extensions.Factory;
using Ninject.Extensions.Factory.Factory;
using RpgAdventure.Models.Interfaces;

namespace RpgAdventure.Core.Ninject.FactoryInstanceProviders
{

    public class PlayableClassFactoryInstanceProvider : IInstanceProvider
    {
        private const string PlayableClassesNamespace = "RpgAdventure.Models.PlayableClasses.Classes.Specialisations";
        private const string AssemblyName = "RpgAdventure.Models";

        private readonly IKernel kernel;

        public PlayableClassFactoryInstanceProvider(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public object GetInstance(IInstanceResolver instanceResolver, MethodInfo methodInfo, object[] arguments)
        {
            string className = $"{PlayableClassesNamespace}.{arguments[0]}";
            string typeParameter = $"{className}, {AssemblyName}";
            Type classType = Type.GetType(typeParameter);
            return this.kernel.Get(classType);
        }
    }
}
