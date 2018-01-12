using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{

    double counter;

    // Use this for initialization
    void Start()
    {
        counter = 0;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward);
        counter += Time.deltaTime;

        if (counter >= 5)
        {
            Destroy(this.gameObject);
        }
    }
}
