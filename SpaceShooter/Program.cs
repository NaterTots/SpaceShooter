using System;

namespace SpaceShooter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (SpaceShooterGame game = new SpaceShooterGame())
            {
                game.Run();
            }
        }
    }
}

