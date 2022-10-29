public class Program
{
    public static void Main()
    {
        ExampleGame exampleGame = new ExampleGame();
        App app = new App(exampleGame);
        app.SetFPS(30);
        app.AddModule(new CoreModule());
        WindowConfig winConfig = new WindowConfig();
        winConfig.title = "Custom Title";
        app.AddModule(new WindowModule(winConfig));
        app.AddModule(new InputModule());

        app.Start();
        app.Run();
    }
}