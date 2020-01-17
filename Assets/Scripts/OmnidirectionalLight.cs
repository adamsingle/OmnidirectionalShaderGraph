using UnityEngine;

[ExecuteInEditMode]
public class OmnidirectionalLight : MonoBehaviour
{
    /// <summary>
    /// The parameter name. This must match the one in your shaders
    /// </summary>
    private static readonly string _shaderPosName = "_OmniLightPos";

    private static readonly string _shaderColorName = "_OmniLightColor";

    [SerializeField] private Color _lightColor;
    
    public void Update()
    {
        Shader.SetGlobalVector(_shaderPosName, transform.position);
        Shader.SetGlobalVector(_shaderColorName, _lightColor);
    }
}
