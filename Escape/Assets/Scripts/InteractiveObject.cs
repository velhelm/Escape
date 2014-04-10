using UnityEngine;
using System.Collections;

public class InteractiveObject : MonoBehaviour {
    public float x = .25f, y = .25f, scale = .25f;
    public float rotx=0, roty=0, rotz=0;
    public GameObject target;
    public Color touchColor;
    bool pickedUp = false;

    void Start()
    {
        if (target == null)
        { target = gameObject; }
        if (touchColor == Color.white)
        { touchColor = Color.white; }
    }

    void OnMouseDown()
    {
        if (!pickedUp)
        {
            target.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(x, y, .5f));
            target.transform.parent = Camera.main.transform;
            target.transform.localScale *= scale;
            target.transform.localEulerAngles = new Vector3(rotx,roty,rotz);

            renderer.material.color = touchColor;

            pickedUp = true;
        }
        else
        {
            //selected item events
        }
    }
}
