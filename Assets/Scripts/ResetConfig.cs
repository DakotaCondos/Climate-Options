//#if UNITY_EDITOR
using UnityEngine;

public class ResetConfig : MonoBehaviour
{
    ProgramManager programManager;

    private void Awake()
    {
        programManager = FindObjectOfType<ProgramManager>();
    }

    public void Activate()
    {
        programManager.ResetClimateControlSystemConfig();
    }
}
// current file contents
//#endif