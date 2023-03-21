using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zip.Dal;

namespace Zip.Entities
{
    public class MainManager
    {
        public MainManager() { init(); }
        private static readonly MainManager _Instance = new MainManager();

        public static MainManager Instance { get { return _Instance; } }

        public CompressManager compressManager = new CompressManager();

        public void init()
        {
            compressManager = new CompressManager();
        }
    }
}
