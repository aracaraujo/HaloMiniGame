using System;
using System.Collections.Generic;


namespace Unit06.Game.Casting
{
    /// <summary>
    /// 
    /// </summary>
    public class Enemy1 : Actor
    {
        private int health = 1;
        private Point position = new Point(0, 0);
        private Point velocity = new Point(0, 0);

        private Body body;
        private Animation animation;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Enemy1(Body body, Animation animation, bool debug = false) : base(debug)
        {
            this.body = body;
            this.animation = animation;
        }
        
        /// <summary>
        /// Gets the body.
        /// </summary>
        /// <returns>The body.</returns>
        public Body GetBody()
        {
            return body;
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <returns>The image.</returns>
        public Animation GetAnimation()
        {
            return animation;
        }

        public void MoveNext(int maxX, int maxY, Point McPosition)
        {
            int x = ((McPosition.GetX() / position.GetX()) + maxX) % maxX;
            int y = ((McPosition.GetY() / position.GetY()) + maxY) % maxY;
            position = new Point(x, y);
        }
    }
}