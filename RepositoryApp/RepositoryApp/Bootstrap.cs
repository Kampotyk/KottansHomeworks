using SimpleInjector;

namespace RepositoryApp
{
    class Bootstrap
    {
        public static Container container;

        public static void Start()
        {
            // 1. Create a new Simple Injector container
            container = new Container();

            // 2. Configure the container (register)
            container.Register<IRepository, Repository>(Lifestyle.Transient);
            container.Register<Printer>(Lifestyle.Transient);

            // 3. Optionally verify the container's configuration.
            container.Verify();
        }
    }
}
