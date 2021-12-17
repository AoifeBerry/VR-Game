using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LineRendererSettings : MonoBehaviour
{
    [SerializeField] LineRenderer rend;
    public LayerMask layerMask;
    public GameObject panel;
    public Image img;
    public Button btn;

    Vector3[] points;

    // Start is called before the first frame update
    void Start()
    {
        rend = gameObject.GetComponent<LineRenderer>();
        img = panel.GetComponent<Image>();
        points = new Vector3[2];
        points[0] = Vector3.zero;
        points[1] = transform.position + new Vector3(0, 0, 20);

        rend.SetPositions(points);
        rend.enabled = true;
        
    }

    public bool AlignLineRenderer(LineRenderer rend)
    {
        
        Ray ray;
        ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        bool hitBtn = false;

        if (Physics.Raycast(ray, out hit, layerMask))
        {
            
            
           
            points[1] = transform.forward + new Vector3(0, 0, hit.distance);
            rend.startColor = Color.red;
            rend.endColor = Color.red;
            btn = hit.collider.gameObject.GetComponent<Button>();
            hitBtn = true;
        }
        else
        {
            hitBtn = false;
            rend.startColor = Color.green;
            rend.endColor = Color.green;
            points[1] = transform.forward + new Vector3(0, 0, 20);
        }
        rend.material.color = rend.startColor;
        rend.SetPositions(points);
        return hitBtn;
    }

   public void StartButton()
    {
        SceneManager.LoadScene("Testing prefabs");


    }
    // Update is called once per frame
    void Update()
    {
        
        if(AlignLineRenderer(rend) && Input.GetAxis("Submit") > 0)
        {
            btn.onClick.Invoke();
        }
        AlignLineRenderer(rend);
    }
}
