using UnityEngine;
using ToolbarControl_NS;

namespace PartAngleDisplay
{
    [KSPAddon(KSPAddon.Startup.MainMenu, true)]
    public class RegisterToolbar : MonoBehaviour
    {
        void Start()
        {
            ToolbarControl.RegisterMod(EditorWindow.MODID, EditorWindow.MODNAME);
        }
    }
}
