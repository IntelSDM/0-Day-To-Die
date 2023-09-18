using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace Cheat
{
    public class Loader  
    {
		public static void Init()
		{
				HackObject.AddComponent<Exploit>();

				UnityEngine.Object.DontDestroyOnLoad(HackObject);
		}
		public static GameObject HackObject = new GameObject(); 
	}
}
