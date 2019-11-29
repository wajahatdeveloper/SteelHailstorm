using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMonoGame.TileMapModule
{
	public class TileSet
	{
		public string sourceFilePath;
		public string name;
		public int tileWidth;
		public int tileHeight;
		public int spacing;
		public int margin;
		public int firstGID;
		public int tileCount;
		public int columns;
		public int tileOffsetX;
		public int tileOffsetY;
		public Color transparentColor;
	}
}
