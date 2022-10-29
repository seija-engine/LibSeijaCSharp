public static class Input {
    static IntPtr inputPtr;
    internal static void updatePtr(IntPtr worldPtr) {
        Input.inputPtr = libseija_input.input_world_get_input(worldPtr);
    }

    public static bool GetKeyDown(KeyCode keyCode) 
    {
        return libseija_input.input_get_keydown(inputPtr,keyCode);
    }

    public static bool GetKeyUp(KeyCode keyCode) 
    {
        return libseija_input.input_get_keyup(inputPtr,keyCode);
    }

    public static bool GetMouseDown(MouseButton keyCode) 
    {
        return libseija_input.input_get_mouse_down(inputPtr,(uint)keyCode);
    }

    public static bool GetMouseUp(MouseButton keyCode) 
    {
        return libseija_input.input_get_mouse_up(inputPtr,(uint)keyCode);
    }
}