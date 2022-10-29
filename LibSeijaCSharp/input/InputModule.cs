public class InputModule : IModule
{
    public void OnAdd(App app)
    {
       libseija_input.input_add_module(app.InnerPtr());
    }
}