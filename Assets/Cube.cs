using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    #region Variables
    [Tooltip("Référence le MeshRenderer du cube"), SerializeField] private MeshRenderer Renderer;
    [Space(5)]
    [Header("Variables 'Float'")]
    [Tooltip("Référence la vitesse de rotation du cube"),SerializeField] private float sRotation;
    [Tooltip("Référence la vitesse de déplacement du cube"),SerializeField] private float sMove;
    [Space(5)]
    [Header("Variables 'Transform'")]
    [Tooltip("Référence la taille du cube"),SerializeField] private Transform scale;
    [Tooltip("Référence les positions des différents points de repos du cube"),SerializeField] private Transform[] planes;
    #endregion

    #region Point system
    ///<summary>
    /// Utiliser un système de liste ou de tableau associer au système
    /// de NavMesh pour permettre le repérage de chaque point ainsi que le déplacement.
    /// </summary>


    #endregion

    #region Movement system
    // transform.position = new Vector3(3, 4, 1);
    #endregion

    #region Material system
    ///<summary>
    /// Utiliser le système de navMesh pour permettre le déplacement.
    /// </summary>

    // public MeshRenderer Renderer;
    // Material material = Renderer.material;
    // material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    #endregion

    #region Rotation system
    // transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
    #endregion

    #region Scale system
    // transform.localScale = Vector3.one * 1.3f;
    #endregion
}