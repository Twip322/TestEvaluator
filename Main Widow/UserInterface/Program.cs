using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;
using DataBaseImplemention.Logic;

namespace UserInterface
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormMain>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<ExaminerLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<QuestionLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<TestLogic>(new HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
