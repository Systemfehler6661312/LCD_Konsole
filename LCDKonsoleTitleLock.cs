using UnityEngine;
using Assets.Scripts.Objects;

public class LCDKonsoleTitleLock : MonoBehaviour
{
    private Display display;
    private Structure structure;

    void Start()
    {
        display = GetComponent<Display>();
        structure = GetComponent<Structure>();
    }

    void Update()
    {
        if (display == null || structure == null)
            return;

        // Weiße Titelzeile, immer Objektname
        string title =
            "<color=#FFFFFF>[ " + structure.CustomName + " ]</color>";

        display.SetLine(0, title);
    }
}