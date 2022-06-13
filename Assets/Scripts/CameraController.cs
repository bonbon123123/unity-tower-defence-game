using UnityEngine;

public class CameraController : MonoBehaviour
{

    private bool doMovement = true;
    public float panSpeed = 30f;
    public float panBorderThiccness = 10f;
    public float scrollSpeed = 5f;
    public float maxY = 60f;
    public float minY = 10f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            doMovement = !doMovement;
        }
        if (!doMovement)
        {
            return;
        }
        if (Input.GetKey("w")|| Input.mousePosition.y>=Screen.height- panBorderThiccness)
        {
            transform.Translate(Vector3.forward*panSpeed*Time.deltaTime,Space.World);

        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThiccness)
        {
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);

        }
        if (Input.GetKey("a") || Input.mousePosition.x <=  panBorderThiccness)
        {
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);

        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThiccness)
        {
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);

        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Vector3 pos = transform.position;
        
        pos.y-= 1000*scroll*scrollSpeed*Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        transform.position = pos;
    }
}
