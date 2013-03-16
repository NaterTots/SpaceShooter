using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceShooter.ScreenManager
{
    public class ScreenManager //TODO: : DrawableGameComponent
    {
        List<GameScreen> allScreens = new List<GameScreen>();
        List<GameScreen> currentScreens = new List<GameScreen>();
        InputState input = new InputState();
        ContentManager content;
    }
}
