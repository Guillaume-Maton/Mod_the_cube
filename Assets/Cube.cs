using System;
using System.Collections;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class Cube : MonoBehaviour
{
    #region Variables
    [SerializeField] private Transform firstPoint, secondPoint, thirdPoint, fourthPoint;

    [Space(5)]
    public float currentTime;
    public int rand;
    public bool timing = false;
    public bool banabread = false;

    Vector3 nextPoint;
    MeshRenderer Renderer;
    #endregion

    #region Méthodes
    void Start()
    {
        Renderer = GetComponent<MeshRenderer>();
        nextPoint = firstPoint.position;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Point"))
        {
            banabread = true;
            StartTimer(5);
        }
    }

    void OnTriggerExit(Collider collision)
    {
        banabread = false;
        StopTimer(currentTime);
    }

    void FixedUpdate()
    {
        // Random position & color
        if (!timing)
        {
            if (banabread)
            {
                UpdateRandom();
            }

            transform.position = Vector3.MoveTowards(transform.position, nextPoint, 10f * Time.deltaTime);
        }

        if (timing)
        {
            if (currentTime > 0)
            {
                currentTime -= Time.deltaTime;
                DisplayTime(currentTime);
            }
            else
            {
                currentTime = 0;
                timing = false;
                DisplayTime(currentTime);
            }
        }
    }

    void UpdateRandom()
    {
        if (!timing)
        {
            rand = UnityEngine.Random.Range(1, 5);
        }

        switch (rand)
        {
            case 1:
                nextPoint = firstPoint.position;
                Renderer.material.color = Color.white;
                transform.localScale = Vector3.one * 1f;
                break;
            case 2:
                nextPoint = secondPoint.position;
                Renderer.material.color = Color.blue;
                transform.localScale = Vector3.one * 1.3f;
                break;
            case 3:
                nextPoint = thirdPoint.position;
                Renderer.material.color = Color.green;
                transform.localScale = Vector3.one * 0.3f;
                break;
            case 4:
                nextPoint = fourthPoint.position;
                Renderer.material.color = Color.red;
                transform.localScale = Vector3.one * 2.3f;
                break;
        }
    }

    #region Timer
    private void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
    }

    void StartTimer(float MaxTime)
    {
        timing = true;
        currentTime = MaxTime;
    }

    void StopTimer(float StopTime)
    {
        timing = false;
        currentTime = StopTime;
    }
    #endregion

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(firstPoint.transform.position, 0.5f);
        Gizmos.DrawWireSphere(secondPoint.transform.position, 0.5f);
        Gizmos.DrawWireSphere(thirdPoint.transform.position, 0.5f);
        Gizmos.DrawWireSphere(fourthPoint.transform.position, 0.5f);

        Gizmos.DrawLine(firstPoint.transform.position, secondPoint.transform.position);
        Gizmos.DrawLine(secondPoint.transform.position, thirdPoint.transform.position);
        Gizmos.DrawLine(thirdPoint.transform.position, fourthPoint.transform.position);
        Gizmos.DrawLine(fourthPoint.transform.position, firstPoint.transform.position);
    }
    #endregion
}