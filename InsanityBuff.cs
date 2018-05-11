using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace InsanityBuff
{
    public class InsanityBuff : Mod
    {
	    internal static InsanityBuff Instance;

	    public InsanityBuff()
	    {
		    Properties = new ModProperties()
		    {
			    Autoload = true,
			    AutoloadGores = true,
			    AutoloadSounds = true,
			    AutoloadBackgrounds = true
			};
		}

	    public override void Load()
	    {
		    Instance = this;
	    }
	}
}
