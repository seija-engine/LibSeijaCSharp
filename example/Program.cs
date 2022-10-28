public class Program
{
    public static void Main()
    {
        App app = new App();
        app.SetFPS(30);
        app.AddModule(new CoreModule());
        WindowConfig winConfig = new WindowConfig();
        winConfig.title = "Custom Title";
        app.AddModule(new WindowModule(winConfig));

        app.Start();
        app.Run();
    }
}