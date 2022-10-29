public class ExampleGame : IGame
{
    public void Start(World world)
    {
        Console.WriteLine("Start Game On:" + Time.Frame);

    }

    public void Update(World world)
    {
        if(Input.GetKeyDown(KeyCode.W)) {
            Console.WriteLine("Down A");
        }
        if(Input.GetKeyUp(KeyCode.W)) {
            Console.WriteLine("Up A");
        }

        if(Input.GetMouseDown(MouseButton.Left)) {
            Console.WriteLine("Down Mouse Left");
        }

        if(Input.GetMouseUp(MouseButton.Left)) {
            Console.WriteLine("Up Mouse Left");
        }
    }
}