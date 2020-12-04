using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slurp_Juice;
using DiscordRPC;

namespace Slurp_Juice.Handler
{
    public static partial class DiscordH
    {
        public static DiscordRpcClient client;

        public static class DiscordHandler
        {
            public static void DiscordID()
            {
                client = new DiscordRpcClient("783806154434281573");
                client.Initialize();
            }

            public static void DiscordStart()
            {
                if (!client.IsInitialized)
                {
                    client.Initialize();
                }
                client.SetPresence(new RichPresence()
                {
                    Details = $"Slurp Juice {Slurp.Version} | Idle",
                    State = $"Viewing homepage",
                    Assets = new Assets()
                    {
                        LargeImageKey = "slurpjuice",
                        LargeImageText = "Slurp Juice open source",
                    }
                });
            }

            public static void HomePage()  //same thing as above, but just doesn't check if discord is initilized since it already will be
            {
                client.SetPresence(new RichPresence()
                {
                    Details = $"Slurp Juice {Slurp.Version} | Idle",
                    State = $"Viewing homepage",
                    Assets = new Assets()
                    {
                        LargeImageKey = "slurpjuice",
                        LargeImageText = "Slurp Juice open source",
                    }
                });
            }

            public static void IdleState()
            {
                client.SetPresence(new RichPresence()
                {
                    Details = $"Slurp Juice {Slurp.Version} | Idle",
                    State = $"Slurrpin on da juice",
                    Assets = new Assets()
                    {
                        LargeImageKey = "slurpjuice",
                        LargeImageText = "Slurp Juice open source",
                    }
                });
            }


            public static void AttachState()
            {
                client.SetPresence(new RichPresence()
                {
                    Details = $"Slurp Juice {Slurp.Version} | Attached",
                    State = $"Slurrpin on da juice",
                    Assets = new Assets()
                    {
                        LargeImageKey = "slurpjuice",
                        LargeImageText = "Slurp Juice open source",
                    }
                });
            }

            public static void ExecuteState()
            {
                client.SetPresence(new RichPresence()
                {
                    Details = $"Slurp Juice {Slurp.Version} | Executed",
                    State = $"Slurrpin on da juice",
                    Assets = new Assets()
                    {
                        LargeImageKey = "slurpjuice",
                        LargeImageText = "Slurp Juice open source",
                    }
                });
            }

            public static void OpenState()
            {
                client.SetPresence(new RichPresence()
                {
                    Details = $"Slurp Juice {Slurp.Version} | Opening file",
                    State = $"Slurrpin on da juice",
                    Assets = new Assets()
                    {
                        LargeImageKey = "slurpjuice",
                        LargeImageText = "Slurp Juice open source",
                    }
                });
            }

            public static void OpenedState() 
            {
                client.SetPresence(new RichPresence()
                {
                    Details = $"Slurp Juice {Slurp.Version} | Opened file",
                    State = $"Slurrpin on da juice",
                    Assets = new Assets()
                    {
                        LargeImageKey = "slurpjuice",
                        LargeImageText = "Slurp Juice open source",
                    }
                });
            }

            public static void SaveState()
            {
                client.SetPresence(new RichPresence()
                {
                    Details = $"Slurp Juice {Slurp.Version} | Saving file",
                    State = $"Slurrpin on da juice",
                    Assets = new Assets()
                    {
                        LargeImageKey = "slurpjuice",
                        LargeImageText = "Slurp Juice open source",
                    }
                });
            }

            public static void SavedState()
            {
                client.SetPresence(new RichPresence()
                {
                    Details = $"Slurp Juice {Slurp.Version} | Saved file",
                    State = $"Slurrpin on da juice",
                    Assets = new Assets()
                    {
                        LargeImageKey = "slurpjuice",
                        LargeImageText = "Slurp Juice open source",
                    }
                });
            }

            public static void ShutDown()
            {
                client.Dispose();
            }

            public static void DevStatus()
            {
                client.SetPresence(new RichPresence()
                {
                    Details = $"Slurp Juice {Slurp.Version} | Dev Status",
                    State = $"Woke hates being sober",
                    Assets = new Assets()
                    {
                        LargeImageKey = "slurpjuice",
                        LargeImageText = "Slurp Juice open source",
                    }
                });
            }

        }
    }
}
