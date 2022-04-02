using RimWorld;
using Verse;

namespace TestMod
{
    [StaticConstructorOnStartup]
    public static class MyFirstRimWorldMod
    {
        static MyFirstRimWorldMod() //our constructor
        {
            Log.Message("Hello Worldddddd!"); //Outputs "Hello World!" to the dev console.
        }
    }
}