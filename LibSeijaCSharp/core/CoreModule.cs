public class CoreModule : IModule
{
    public void OnAdd(App app) {
        libseija_core.core_add_module(app.InnerPtr());
    }
}

