using System.Runtime.InteropServices;

public interface IModule {
    void OnAdd(App app);
}

public class App {
    IntPtr appPtr;

    public App() {
        this.appPtr = libseija_app.app_new();
    }

    public IntPtr InnerPtr() {
        return this.appPtr;
    }

    public void AddModule(IModule module) {
        module.OnAdd(this);
    }
    
    public void SetFPS(uint fps) {
        libseija_app.app_set_fps(this.appPtr,fps);
    }

    public void Start() {
        libseija_app.app_start(this.appPtr);
    }

    public void Run() {
        libseija_app.app_run(this.appPtr);
    }

   
}