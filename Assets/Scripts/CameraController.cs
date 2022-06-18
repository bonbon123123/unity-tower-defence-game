using UnityEngine;

public class CameraController : MonoBehaviour
{

    private bool doMovement = true;
    public float panSpeed = 30f;
    public float panBorderThiccness = 10f;
    public float scrollSpeed = 5f;
    public float maxY = 60f;
    public float minY = 10f;

    public float maxX = 0f;
    public float minX = -10f;

    public float maxZ = 0f;
    public float minZ = 0f;

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
            Vector3 posZ = transform.position;

            posZ.z += 1*panSpeed * Time.deltaTime;
            posZ.z = Mathf.Clamp(posZ.z, minZ, maxZ);
            transform.position = posZ;

            //transform.Translate(Vector3.forward*panSpeed*Time.deltaTime,Space.World);

        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThiccness)
        {
            Vector3 posZ = transform.position;

            posZ.z -= 1 * panSpeed * Time.deltaTime;
            posZ.z = Mathf.Clamp(posZ.z, minZ, maxZ);
            transform.position = posZ;
            //transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);

        }
        if (Input.GetKey("a") || Input.mousePosition.x <=  panBorderThiccness)
        {
            Vector3 posX = transform.position;

            posX.x -= 1 * panSpeed * Time.deltaTime;
            posX.x = Mathf.Clamp(posX.x, minX, maxX);
            transform.position = posX;

            //transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);

        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThiccness)
        {
            Vector3 posX = transform.position;

            posX.x += 1 * panSpeed * Time.deltaTime;
            posX.x = Mathf.Clamp(posX.x, minX, maxX);
            transform.position = posX;
            //transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);

        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Vector3 pos = transform.position;
        
        pos.y-= 1000*scroll*scrollSpeed*Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        transform.position = pos;
    }
}
