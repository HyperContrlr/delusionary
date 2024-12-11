using UnityEngine.Events;
using UnityEngine;

public class physicalButton : MonoBehaviour
{
    public UnityEvent onClick;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hitInfo) && hitInfo.collider.gameObject == gameObject)
            {
                onClick.Invoke();
            }
        }
    }
}
