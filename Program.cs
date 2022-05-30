using System;

namespace FarAway{
    public static class Program{
        [STAThread]
        static void Main(){
            using (var game = new src.Main()) {
                game.Run();
            }
        }
    }
}
