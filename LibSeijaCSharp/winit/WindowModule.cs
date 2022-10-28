using System.Runtime.InteropServices;
public enum WindowMode {
    Windowed,
    BorderlessFullscreen,
    Fullscreen,
}
[StructLayout(LayoutKind.Sequential)]
public struct WindowConfig {
    public float Width;
    public float Height;
    public WindowMode mode;

    public bool vsync;
    
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    public string title;
    public WindowConfig() {
        this.Width = 320;
        this.Height = 240;
        this.mode = WindowMode.Windowed;
        this.vsync = false;
        this.title = "SeijaEngine";
    }
    public IntPtr Build() {
        IntPtr configPtr = libseija_winit.winit_new_windowconfig();
        Marshal.StructureToPtr(this,configPtr,true);
        libseija_winit.winit_windowconfig_set_title(configPtr,this.title);
        return configPtr;
    }
}

public class WindowModule : IModule
{
    IntPtr configPtr;
    public WindowModule(WindowConfig config) {
         this.configPtr = config.Build();
    }
    public void OnAdd(App app)
    {
        libseija_winit.winit_add_module(app.InnerPtr(),this.configPtr);
    }
}
