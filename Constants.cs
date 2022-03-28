using System.Collections.Generic;
using HaloMiniGame.Game.Casting;


namespace HaloMiniGame
{
    public class Constants
    {

        public static string GAME_NAME = "Halo Mini Game";
        public static int FRAME_RATE = 60;

        // SCREEN
        public static int SCREEN_WIDTH = 1040;
        public static int SCREEN_HEIGHT = 680;
        public static int CENTER_X = SCREEN_WIDTH / 2;
        public static int CENTER_Y = SCREEN_HEIGHT / 2;

        // FIELD
        public static int FIELD_TOP = 60;
        public static int FIELD_BOTTOM = SCREEN_HEIGHT;
        public static int FIELD_LEFT = 0;
        public static int FIELD_RIGHT = SCREEN_WIDTH;

        // FONT
        public static string FONT_FILE = "Assets/Fonts/Halo.ttf";
        public static int FONT_SIZE = 32;

        // SOUND - Need to find yet 
        // public static string BOUNCE_SOUND = "Assets/Sounds/boing.wav";
        // public static string WELCOME_SOUND = "Assets/Sounds/start.wav";
        // public static string OVER_SOUND = "Assets/Sounds/over.wav";

        // TEXT
        public static int ALIGN_LEFT = 0;
        public static int ALIGN_CENTER = 1;
        public static int ALIGN_RIGHT = 2;


        // COLORS
        public static Color BLACK = new Color(0, 0, 0);
        public static Color WHITE = new Color(255, 255, 255);
        public static Color PURPLE = new Color(255, 0, 255);

        // KEYS
        public static string LEFT = "left";
        public static string RIGHT = "right";
        public static string SPACE = "space";
        public static string ENTER = "enter";
        public static string PAUSE = "p";

        // SCENES
        public static string NEW_GAME = "new_game";
        public static string TRY_AGAIN = "try_again";
        public static string NEXT_LEVEL = "next_level";
        public static string IN_PLAY = "in_play";
        public static string GAME_OVER = "game_over";

        // LEVELS - Need tgo figured it out yet
        // public static string LEVEL_FILE = "Assets/Data/level-{0:000}.txt";
        // public static int BASE_LEVELS = 5;

        // ----------------------------------------------------------------------------------------- 
        // SCRIPTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // PHASES
        public static string INITIALIZE = "initialize";
        public static string LOAD = "load";
        public static string INPUT = "input";
        public static string UPDATE = "update";
        public static string OUTPUT = "output";
        public static string UNLOAD = "unload";
        public static string RELEASE = "release";

        // ----------------------------------------------------------------------------------------- 
        // CASTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // STATS
        public static string STATS_GROUP = "stats";
        public static int DEFAULT_LIVES = 3;
        public static int MAXIMUM_LIVES = 5;

        // HUD
        public static int HUD_MARGIN = 15;
        public static string LEVEL_GROUP = "level";
        public static string LIVES_GROUP = "lives";
        public static string TIMER_GROUP = "timer";
        public static string LEVEL_FORMAT = "LEVEL: {0}";
        public static string LIVES_FORMAT = "LIVES: {0}";
        public static string TIMER_FORMAT = "TIMER: {0}";

        // // Captain - Personage
        public static string MASTERCHIEF_GROUP = "masterchief";
        //Master chief sprint
        //public static string MASTERCHIEF_IMAGE = "Assets/Images/000.png";
        // public static int MASTERCHIEF_WIDTH = 28;
        // public static int MASTERCHIEF_HEIGHT = 28;
        // public static int MASTERCHIEF_VELOCITY = 6;

        // // RACKET - Example of how handle the sprints of the captain
        // public static string RACKET_GROUP = "rackets";
        
        // public static List<string> RACKET_IMAGES
        //     = new List<string>() {
        //         "Assets/Images/100.png",
        //         "Assets/Images/101.png",
        //         "Assets/Images/102.png"
        //     };


        // BRICK
        public static string MONSTERS_GROUP = "monster";
        
        // Add monsters sprint
        // public static Dictionary<string, List<string>> BRICK_IMAGES
        //     = new Dictionary<string, List<string>>() {
        //         { "b", new List<string>() {
        //             "Assets/Images/010.png",
        //             "Assets/Images/011.png",
        //             "Assets/Images/012.png",
        //             "Assets/Images/013.png",
        //             "Assets/Images/014.png",
        //             "Assets/Images/015.png",
        //             "Assets/Images/016.png",
        //             "Assets/Images/017.png",
        //             "Assets/Images/018.png"
        //         } }
        };

        // public static int BRICK_WIDTH = 80;
        // public static int BRICK_HEIGHT = 28;
        // public static double BRICK_DELAY = 0.5;
        // public static int BRICK_RATE = 4;
        // public static int BRICK_POINTS = 50;

        // // DIALOG - Create our own dialogue
        // public static string DIALOG_GROUP = "dialogs";
        // public static string ENTER_TO_START = "PRESS ENTER TO START";
        // public static string PREP_TO_LAUNCH = "PREPARING TO LAUNCH";
        // public static string WAS_GOOD_GAME = "GAME OVER";


















    }
}