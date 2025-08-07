namespace LightningDevelopment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Dema.VisualStudio;
    using MHGameWork;

    public class ActionsModule : IActionsModule
    {
        #region Fields

        private Dictionary<string, IQuickAction> actions = new Dictionary<string, IQuickAction>();
        private LightningDevelopmentHandle handle;

        #endregion Fields

        #region Constructors

        public ActionsModule(LightningDevelopmentHandle lightningDevelopmentHandle)
        {
            handle = lightningDevelopmentHandle;
        }

        #endregion Constructors

        #region Methods

        public static ActionsModule CreateFromDll(string dll, LightningDevelopmentHandle lightningDevelopmentHandle)
        {
            var ret = new ActionsModule(lightningDevelopmentHandle);
            ret.loadAssembly(Assembly.LoadFrom(dll));
            return ret;
        }

        public static ActionsModule CreateFromProject(string projectFile, string outputFile, LightningDevelopmentHandle lightningDevelopmentHandle)
        {
            var engine = new Microsoft.Build.Evaluation.Project(projectFile);
            var myLog = new VSOutputLogger();
            bool bolIsSuccess = engine.Build(myLog);
            bool bol = engine.IsDirty;//.ToolsVersion();
            return CreateFromDll(outputFile, lightningDevelopmentHandle);
        }

        public bool ContainsAction(string txt)
        {
            return actions.ContainsKey(txt);
        }

        public void RunAction(string action, string[] arguments)
        {
            actions[action].Execute(arguments);
        }

        public void RunAction(string txt)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<Type> listPlugins(Assembly ass)
        {
            return ass.GetTypes().Where(t => t.GetInterfaces().Count(i => i == typeof(IPlugin)) != 0);
        }

        private IEnumerable<Type> listQuickActions(Assembly ass)
        {
            return ass.GetTypes().Where(t => t.GetInterfaces().Count(i => i == typeof(IQuickAction)) != 0);
        }

        private void loadAssembly(Assembly modulesAssembly)
        {
            var actionTypes = listQuickActions(modulesAssembly);

            foreach (var pluginType in listPlugins(modulesAssembly))
            {
                IPlugin plugin = (IPlugin)Activator.CreateInstance(pluginType);
                plugin.Initialize(handle);
                DI.CurrentBindings.SetBinding(pluginType, plugin);
            }

            foreach (var type in actionTypes)
            {
                var obj = (IQuickAction)Activator.CreateInstance(type);
                actions.Add(obj.Command, obj);
            }
        }

        #endregion Methods
    }
}