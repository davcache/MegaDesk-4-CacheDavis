using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_CacheDavis
{
    public class Desk
    {
        public enum DesktopMaterial
        {
            Laminate,
            Oak,
            Pine,
            Rosewood,
            Veneer
        }
        public decimal Width { get; set; }

        public decimal Depth { get; set; }

        public int NumDrawers { get; set; }

        public DesktopMaterial desktop { get; set; }
    }
}
