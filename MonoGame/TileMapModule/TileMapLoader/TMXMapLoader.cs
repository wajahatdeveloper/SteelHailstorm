using HelloMonoGame.TileMapModule;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGame.TileMapModule.TileMapLoader.TMXMapLoader
{
	// TMX MAP FORMAT
	// Version 1.1

	public class TMXMapLoader
	{
		TileMap LoadTileMap(string filePath)
		{
			Debug.Print(filePath);
			return new TileMap();
		}
	}
}
