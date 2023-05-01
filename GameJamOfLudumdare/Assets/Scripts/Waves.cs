using UnityEngine;
using FluffyUnderware.Curvy;
using FluffyUnderware.Curvy.Controllers;

public class Waves : MonoBehaviour
{
    public GameObject bottle;
    public CurvySpline spline;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R)&& bottle.transform.GetComponent<Movement>().SplineNow==spline)
        {
            foreach (Transform child in transform)
            {
                SplineController controller = child.GetComponent<SplineController>();
                if (controller != null)
                {
                    if(controller.MovementDirection == MovementDirection.Forward)
                        controller.MovementDirection = MovementDirection.Backward;
                    else
                        controller.MovementDirection = MovementDirection.Forward;
                }
            }
        }

    }
}
