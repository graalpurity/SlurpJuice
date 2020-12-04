using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slurp_Juice.Handler;
using static Slurp_Juice.Handler.DiscordH;

namespace Slurp_Juice.Handler
{
    public static partial class EditorH
    {
       public static class EditorHandler
        {
           public static void Read()
            {
                if (Slurp.SlurpEditorString == "DevStatus()") DiscordHandler.DevStatus();
            }
        }
    }
}
