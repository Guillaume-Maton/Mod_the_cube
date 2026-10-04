using System.Collections;
using System.Drawing;
using UnityEngine;
using UnityEngine.AI;

public class Cube : MonoBehaviour
{
    #region Variables
    [Tooltip(""), SerializeField] private NavMeshAgent agent;
    [SerializeField] private int point;
    [Tooltip("Référence le MeshRenderer du cube"), SerializeField] private MeshRenderer Renderer;
    [Space(5)]
    [Header("Timer")]
    [Tooltip(""), SerializeField] private float currentTime;
    [SerializeField] private bool isTime = false;
    [Space(5)]
    [Header("Variables 'Float'")]
    [Tooltip("Référence la vitesse de rotation du cube"),SerializeField] private float sRotation;
    [Tooltip("Référence la vitesse de déplacement du cube"),SerializeField] private float sMove;
    [Space(5)]
    [Header("Variables 'Transform'")]
    [Tooltip("Référence la taille du cube"),SerializeField] private Transform scale;
    [Tooltip("Référence les positions des différents points de repos du cube"),SerializeField] private Transform[] planes;
    [SerializeField] private Transform current;
    #endregion

    #region Point system
    ///<summary>
    /// Utiliser un système de liste ou de tableau associer au système
    /// de NavMesh pour permettre le repérage de chaque point ainsi que le déplacement.
    /// </summary>
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (isTime)
        {
            if(currentTime > 0)
            {
                currentTime -= Time.deltaTime;

            }
            else
            {
                currentTime = 0;
                isTime = false;
            }
        }

        //Cuble(current.transform.position);

        /*if (timing)
        {
            current = planes[point];
            //timing = false;
            StopCoroutine(ItsTimingTime());
        }
        else
        {
            StartCoroutine(ItsTimingTime());
        }

        Debug.Log(current);*/
    }

    /*IEnumerator ItsTimingTime()
    {
        Timer = 20f;
        yield return new WaitForSeconds(Timer);
        timing = true;
        point = Random.Range(0, 4);
    }*/

    #endregion

    #region Movement system

    /*void Cuble (Vector3 location)
    {
        agent.SetDestination(location);
    }*/

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