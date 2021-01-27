using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using ShadowCheats;
using Slurp_Juice;
using System.Threading;

namespace Slurp_Juice.Handler
{
    public partial class APIH
    {
        public static ShadowCheats.Module api = new ShadowCheats.Module();
        

        public static class APIHandler
        {
            public static void Attach()
            {
                api.Attach();
            }

            public static void AttachThread()
            {
                Thread thread = new Thread(Attach);
            }

            public static void Execute()
            {
                api.ExecuteScript(Slurp.SlurpEditorString);
            }

            public static void ExecuteTask()
            {
                Task.Factory.StartNew(() => Execute());
            }
        }
    }
}
