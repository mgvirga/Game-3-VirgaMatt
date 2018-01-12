using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Player1 : MonoBehaviour
{
    Vector3 startPos;
    public float speed;
    public GameObject countText;
    public GameObject winText;
    public GameObject Player1prefab;

   // private Rigidbody rb;
    private int count;
    public GameObject Player;


    void Start()
    {
        startPos = gameObject.transform.position;
        //rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.GetComponent<Text>().text = "";

    }

    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal2");
        float moveVertical = Input.GetAxis("Vertical2");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Player.GetComponent<Rigidbody>().velocity = movement * speed;


    }
    void OnTriggerEnter(Collider other)


    {
        if (other.gameObject.CompareTag("Respawn"))
        {
            gameObject.transform.position = startPos;
            //Destroy(other.gameObject);
           // Instantiate(Player1prefab, new Vector3(5.866f,3.536f,0.329f), Quaternion.identity);

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

