using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMonoGame.TileMapModule
{
	public class TileMap
	{
		TileMap(string filePath)
		{
			tileMap = new Tiled.TiledMap(filePath);
		}

		public Tiled.TiledMap tileMap;
	}
}
