using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public Rigidbody door;
    public Vector3 m_EulerAngleVelocity;

    // Start is called before the first frame update
    void Start()
    {
        door = GetComponent<Rigidbody>();
        m_EulerAngleVelocity = new Vector3(0,3000,0);
        door.position = new Vector3(0.92f, 2.72f, 4.99f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0)) {
            Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.deltaTime);
            door.MoveRotation(door.rotation * deltaRotation);
            
            door.position = new Vector3(2f, 2.8f, 7f);

            StartCoroutine(WaitForSceneLoad());
        }
    }

    private IEnumerator WaitForSceneLoad() {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("SceneTwo");
    }
}
