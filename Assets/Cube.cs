using System.Collections;
using System.Drawing;
using UnityEngine;
using UnityEngine.AI;

public class Cube : MonoBehaviour
{
    #region Variables
    [SerializeField] private MeshRenderer Renderer;
    [Tooltip("Référence la vitesse de rotation du cube"),SerializeField] private float sRotation;
    [Tooltip("Référence la vitesse de déplacement du cube"),SerializeField] private float sMove;
    [Tooltip("Référence la taille du cube"),SerializeField] private Transform scale;
    #endregion

    // basiquement je voulais faire un système de navigation par mesh mais je pense que je vais retravailler mon système
    // pour le rendr moins compliquer car j'ai vu les autres résultats et ils n'attendent pas forcement à des choses aussi complexe.

    #region Méthodes
    void Start()
    {
    }

    // référence du material : Material material = Renderer.material;
    // couleur du material : material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);

    // position : transform.position = new Vector3(3, 4, 1);

    // rotation : transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);

    // taille : transform.localScale = Vector3.one * 1.3f;
    #endregion
}