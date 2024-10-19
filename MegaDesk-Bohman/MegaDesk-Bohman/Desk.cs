using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Bohman
{
    public class Desk
    {
        public int width;
        public int depth;
        public int numDrawers;
        public DesktopMaterial material;
        static public int MIN_WIDTH = 24;
        static public int MAX_WIDTH = 96;
        static public int MIN_DEPTH = 12;
        static public int MAX_DEPTH = 48;
        static public string APPENDED_MEASUREMENT_UNIT = " in.";
        static public List<DesktopMaterial> materials = (Enum.GetValues(typeof(DesktopMaterial))).Cast<DesktopMaterial>().ToList();

        public Desk(int width, int depth, int numDrawers, DesktopMaterial material)
        {
            this.width = width;
            this.depth = depth;
            this.numDrawers = numDrawers;
            this.material = material;
        }
    }

    public enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
    public enum Size
    {
        small,
        medium,
        large
    };
}
