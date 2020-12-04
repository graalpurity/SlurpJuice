using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using WeAreDevs_API;
using Slurp_Juice;

namespace Slurp_Juice.Handler
{
    public partial class APIH
    {
        public static ExploitAPI api = new ExploitAPI();

        public static class APIHandler
        {
            public static void Attach()
            {
                api.LaunchExploit();

            }

            public static void AttachTask()
            {
                Task.Factory.StartNew(() => Attach());
            }

            public static void Execute()
            {
                api.SendLuaScript(Slurp.SlurpEditorString);
            }

            public static void ExecuteTask()
            {
                Task.Factory.StartNew(() => Execute());
            }

            public static void ESP()
            {
                api.SendLuaScript(Slurp.SlurpEditorString = "boxesp");
            }

            public static void showconsole()
            {
                api.SendLuaScript(Slurp.SlurpEditorString = "WRDAPI.ShowConsole()");
            }

            public static void showconsoleoff()
            {
                api.SendLuaScript(Slurp.SlurpEditorString = "WRDAPI.HideConsole()");
            }
        }
    }
}
