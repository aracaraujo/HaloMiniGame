using Raylib_cs;
using HaloMiniGame.Game.Casting;

namespace HaloMiniGame.Game.Services
{
    public class RaylibMouseService : MouseService
    {
        private Dictionary<string, Raylib_cs.MouseButton> buttons
                = new Dictionary<string, Raylib_cs.MouseButton>() 
        {
            { "left", Raylib_cs.MouseButton.MOUSE_LEFT_BUTTON },
            { "middle", Raylib_cs.MouseButton.MOUSE_MIDDLE_BUTTON },
            { "right", Raylib_cs.MouseButton.MOUSE_RIGHT_BUTTON }
        };

        /// </inheritdoc>
        public Point GetCoordinates()
        {
            int x = Raylib.GetMouseX();
            int y = Raylib.GetMouseY();
            return new Point(x, y);
        }

        /// </inheritdoc>
        public bool IsButtonDown(string button)
        {
            Raylib_cs.MouseButton raylibButton = buttons[button.ToLower()];
            return Raylib.IsMouseButtonDown(raylibButton);
        }

        /// </inheritdoc>
        public bool IsButtonPressed(string button)
        {
            Raylib_cs.MouseButton raylibButton = buttons[button.ToLower()];
            return Raylib.IsMouseButtonPressed(raylibButton);
        }

        /// </inheritdoc>
        public bool IsButtonReleased(string button)
        {
            Raylib_cs.MouseButton raylibButton = buttons[button.ToLower()];
            return Raylib.IsMouseButtonReleased(raylibButton);
        }

        /// </inheritdoc>
        public bool IsButtonUp(string button)
        {
            Raylib_cs.MouseButton raylibButton = buttons[button.ToLower()];
            return Raylib.IsMouseButtonUp(raylibButton);
        }
    
    }
}