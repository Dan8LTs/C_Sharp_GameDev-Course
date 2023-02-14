using Encapsulation;

Renderer renderer = new Renderer();
Player player = new Player(62, 12);

/* 
Encapsulation is protection against unwanted external change.
player.X = -1000;
player.Y = -1000;
*/

renderer.Draw(player.X, player.GetY());