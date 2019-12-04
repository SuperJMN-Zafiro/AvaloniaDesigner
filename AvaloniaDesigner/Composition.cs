using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Avalonia.Controls;
using Designer.Core;
using Designer.Core.Persistence;
using Designer.Core.Tools;
using Designer.Domain.ViewModels;
using DynamicData;
using Grace.DependencyInjection;
using Zafiro.Avalonia;
using Zafiro.Core;
using Zafiro.Core.Files;

namespace AvaloniaDesigner
{
    public class Composition
    {
        private static readonly DependencyInjectionContainer Container;

        static Composition()
        {
            Container = new DependencyInjectionContainer();
            Container.Configure(registrationBlock =>
            {
                var toolType = typeof(Tool);
                var assembly = typeof(RectangleTool).Assembly;

                registrationBlock.Export(assembly.ExportedTypes
                        .Where(TypesThat.AreBasedOn<Tool>())
                        .Where(x => !x.IsAbstract))
                    .ByTypes(type => new[] { toolType });

                registrationBlock.Export<AvaloniaFilePicker>().As<IFilePicker>().Lifestyle.Singleton();
                registrationBlock.Export<DesignContext>().As<IDesignContext>().Lifestyle.Singleton();
                registrationBlock.Export<ViewModelFactory>().As<IViewModelFactory>().Lifestyle.Singleton();
                registrationBlock.Export<ProjectStore>().As<IProjectStore>().Lifestyle.Singleton();
                registrationBlock.Export<ServiceFactory>().As<IServiceFactory>().Lifestyle.Singleton();
                registrationBlock.ExportFactory((IServiceFactory factory, IFilePicker picker) => new FakeExtensionsProvider()).As<IExtensionsProvider>().Lifestyle.Singleton();
                registrationBlock.Export<ProjectMapper>().As<IProjectMapper>().Lifestyle.Singleton();
                registrationBlock.Export<ImportExtensionsViewModel>().Lifestyle.Singleton();
                registrationBlock.Export<MainViewModel>().Lifestyle.Singleton();
                registrationBlock.ExportFactory(() => GetMainWindow()).As<Window>();
            });
        }

        private static Window GetMainWindow()
        {
            return Window;
        }

        public static MainViewModel Root => Container.Locate<MainViewModel>();

        public ImportExtensionsViewModel Import => Container.Locate<ImportExtensionsViewModel>();
        public static Window Window { get; set; }
    }

    public class ServiceFactory : IServiceFactory
    {
        public IDictionaryBasedService Create(string packageFamilyName, string serviceName)
        {
            return new FakeAppService();
        }
    }

    public class FakeAppService : IDictionaryBasedService
    {
        public Task<Payload> Request(Payload payload)
        {
            throw new NotImplementedException();
        }
    }

    public class FakeExtensionsProvider : IExtensionsProvider
    {
        public IObservable<IChangeSet<ImportViewModel, string>> ObservableChangeset { get; } = Observable.Empty<IChangeSet<ImportViewModel, string>>();
        public ReadOnlyObservableCollection<ImportViewModel> Extensions { get; } = new ReadOnlyObservableCollection<ImportViewModel>(new ObservableCollection<ImportViewModel>());
    }
}