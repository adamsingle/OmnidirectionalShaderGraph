using System;
using UnityEngine;

namespace OmnidirectionalLightTest
{
    /// <summary>
    /// https://gamedev.stackexchange.com/a/128144
    /// </summary>
    public class Orbit : MonoBehaviour
    {
        [SerializeField] private float _orbitSpeed = 1f;
        [SerializeField] private float _alpha = 0f;
        [SerializeField] private float _tilt = 45f;

        private void Update()
        {
            transform.localPosition = new Vector2(
                0f + (10f * MCos(_alpha) * MCos(_tilt) - 5f * MSin(_alpha) * MSin(_tilt)),
                0f + (10f * MCos(_alpha) * MSin(_tilt) + 5f * MSin(_alpha) * MCos(_tilt)));

            _alpha += _orbitSpeed;
        }

        private float MCos(float value)
        {
            return Mathf.Cos(Mathf.Deg2Rad * value);
        }

        private float MSin(float value)
        {
            return Mathf.Sin(Mathf.Deg2Rad * value);
        }
    }
}