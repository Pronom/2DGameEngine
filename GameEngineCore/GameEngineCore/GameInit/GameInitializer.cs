using SolutionAssembliesLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


namespace GameEngineCore.GameInit
{
    public class GameInitializer
    {
        List<Assembly> _assemblies;
        Type lookForTypeOf;
        public GameInitializer(Type type)
        {

            _assemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();

            lookForTypeOf = type;
            _assemblies = new AssemblyLoader().Assemblies;
            InitGameObject();


        }


        private void InitGameObject()
        {
            foreach (Assembly assembly in _assemblies)
            {
                var assemblyContent = assembly
                    .GetTypes()
                    .ToList();
                foreach (var item in assemblyContent)
                {
                    if (item.BaseType == lookForTypeOf)
                    {
                        Activator.CreateInstance(item);
                    }
                }
            }
        }
    }
       
}
