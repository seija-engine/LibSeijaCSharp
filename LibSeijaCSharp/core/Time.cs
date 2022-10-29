public static class Time {
    static IntPtr timePtr;

    internal static void updatePtr(IntPtr world) {
        timePtr = libseija_core.core_world_get_time(world);;
    }

    public static ulong Frame { get {
       return libseija_core.core_time_get_frame(timePtr);        
    }}

    public static float Delta { get {
       return libseija_core.core_time_get_delta_seconds(timePtr);        
    }}
}