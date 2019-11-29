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
		public string version;
		public int orientation;
		public int renderOrder;
		public int widthInTiles;
		public int heightInTiles;
		public int tileWidthPixels;
		public int tileHeightPixels;
		public Color backgroundColor;

		public TileSet tileset;
		public List<TileLayer> tileLayers = new List<TileLayer>();

		public void Load(string filePath)
		{
		}
	}
}
