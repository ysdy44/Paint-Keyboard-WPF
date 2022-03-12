using System.Collections.Generic;

namespace Paint_Keyboard.Model
{
    public sealed class Solution
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public IEnumerable<Item> Items { get; set; }
    }
}