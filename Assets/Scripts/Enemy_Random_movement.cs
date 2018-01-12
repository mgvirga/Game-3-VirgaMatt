using UnityEngine;
using System.Collections;

public class Enemy_Random_movement : MonoBehaviour
{


    public float timer;

    public int newtarget;

    public float speed;

    public UnityEngine.AI.NavMeshAgent nav;

    public Vector3 Target;

    // Use this for initialization
    void Start()
    {

        nav = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (timer >= 3)
        {
            newTarget();
            timer = 0;
        }
    }

    void newTarget()
    {
        float myX = gameObject.transform.position.x;
        float myZ = gameObject.transform.position.z;

        float xPos = myX + Random.Range(myX - 100, myX + 100);
        float zPos = myZ + Random.Range(myZ - 100, myZ + 100);

        Target = new Vector3(xPos, gameObject.transform.position.y, zPos);

        nav.SetDestination(Target);
    }
}
