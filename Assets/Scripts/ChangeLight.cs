using UnityEngine;

/// <summary>
/// 指示灯.
/// </summary>
public class ChangeLight : MonoBehaviour
{
    private Material mat;

    private void Awake()
    {
        mat = GetComponent<MeshRenderer>().material;
       
    }
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F3))
        {
            SetEmission(mat,true);
        }

        if (Input.GetKeyDown(KeyCode.F4))
        {
            SetEmission(mat, false );
        }
    }

    private void SetEmission(Material mat, bool emissionOn)
    {
        if (emissionOn)
        {
            mat.EnableKeyword("_EMISSION");
        }
        else
        {
            mat.DisableKeyword("_EMISSION");
        }
    }
}
