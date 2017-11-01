using SolutionAssembliesLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


namespace GameEngineCore.GameInit
{
    /// <summary>
    /// Initialise le jeu en instanciant chaque classe de jeu
    /// </summary>
    public class GameInitializer
    {
        List<Assembly> _assemblies;
        Type lookForTypeOf;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type">Type hérité à recherché pour l'instanciation des enfants</param>
        public GameInitializer(Type type)
        {
            lookForTypeOf = type;
            _assemblies = new AssemblyLoader().Assemblies;
            InitGameObject();
        }

        /// <summary>
        /// Instancie chaque fichiers du projet héritant du type précisé dans le constructeur
        /// </summary>
        private void InitGameObject()
        {
            foreach (Assembly assembly in _assemblies)
            {
                var assemblyContent = assembly
                    .GetTypes()
                    .ToList();
                foreach (var item in assemblyContent)
                {
                    var currentType = item;

                    while (currentType != null)
                    {
                        if (currentType.BaseType == lookForTypeOf)
                        {
                            Activator.CreateInstance(item);
                        }

                        currentType = currentType.BaseType;
                    }
                }
            }
        }
    }

}
