public interface IModule {
    void OnAdd(App app);
}

public interface IGame {
    public void Start(World world) {}

    public void Update(World world) {}
}

public class App {
    IntPtr appPtr;
    libseija_core.WorldFN startFN;
    libseija_core.WorldFN updateFN;

    IGame game;
    
    World world = new World();
    public App(IGame game) {
        this.game = game;
        this.appPtr = libseija_app.app_new();
        this.startFN = new libseija_core.WorldFN(this._start);
        this.updateFN = new libseija_core.WorldFN(this._update);
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
        libseija_core.app_set_on_start(this.appPtr,this.startFN);
        libseija_core.app_set_on_update(this.appPtr,this.updateFN);
        libseija_app.app_run(this.appPtr);
    }

    public void _start(IntPtr world) {
        this.world.initPtr(world);
        Time.updatePtr(world);
        this.game.Start(this.world);
    }

    public void _update(IntPtr world) {
        Time.updatePtr(world);
        Input.updatePtr(world);
        this.game.Update(this.world);
    }
   
}