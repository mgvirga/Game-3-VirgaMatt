using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerGame3 : MonoBehaviour
{
    public GameObject countText;
    public GameObject winText;

    //private Rigidbody rb;
    private int count;
    public float speed;
    Vector3 startPos;

    public GameObject Player2;

    void Start()
    {
        startPos = gameObject.transform.position;
        //rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.GetComponent<Text>().text = "";

    }


    void Update()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Player2.GetComponent<Rigidbody>().velocity = movement * speed;
    }


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Respawn"))
        {
            gameObject.transform.position = startPos;
            

        }

        else if (other.gameObject.CompareTag("Enemy"))
        {
            gameObject.transform.position = startPos;
        }
        else if (other.gameObject.CompareTag("shot"))
        {
            gameObject.transform.position = startPos;
        }
        else if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.GetComponent<Text>().text = "Count: " + count.ToString();
        if (count >= 1)
        {
            winText.GetComponent<Text>().text = "You Win!";
        }
    }
}

