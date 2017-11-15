using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections;

namespace FirstProject
{

    class Player
    {
        Sprite sprite = new Sprite();

        // Butchered Code from First Project
        float playerSpeed = 50;
        Vector2 playerPosition = new Vector2(0, 0);
        Vector2 playerOffset = new Vector2(0, 0);
        public Player()
        {

        }
        public void Load(ContentManager content)
        {
            sprite.Load(content, "hero");
        }
        public void Update(GameTime gameTime)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (Keyboard.GetState().IsKeyDown(Keys.Up) == true)
            {
                playerPosition.Y -= playerSpeed * deltaTime;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down) == true)
            {
                playerPosition.Y += playerSpeed * deltaTime;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left) == true)
            {
                playerPosition.X -= playerSpeed * deltaTime;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right) == true)
            {
                playerPosition.X += playerSpeed * deltaTime;
            }
            sprite.position = playerPosition;
            sprite.Update(deltaTime);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch);
        }
    }
}
