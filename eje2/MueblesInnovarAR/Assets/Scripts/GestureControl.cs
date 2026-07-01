using UnityEngine;

public class GestureControl : MonoBehaviour
{
    private float rotationSpeed = 200f;
    private float scaleSpeed = 0.01f;
    private float minScale = 0.1f;
    private float maxScale = 3.0f;

    void Update()
    {
        // ROTACIÓN: Un dedo deslizando
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                float rotationAmount = touch.deltaPosition.x * rotationSpeed * Time.deltaTime;
                transform.Rotate(Vector3.up, -rotationAmount);
            }
        }

        // ESCALADO: Pinch con dos dedos
        if (Input.touchCount == 2)
        {
            Touch touch0 = Input.GetTouch(0);
            Touch touch1 = Input.GetTouch(1);

            // Distancia actual y anterior entre los dos dedos
            Vector2 touch0PrevPos = touch0.position - touch0.deltaPosition;
            Vector2 touch1PrevPos = touch1.position - touch1.deltaPosition;

            float prevMagnitude = (touch0PrevPos - touch1PrevPos).magnitude;
            float currentMagnitude = (touch0.position - touch1.position).magnitude;

            float difference = currentMagnitude - prevMagnitude;

            // Aplicar escala
            Vector3 newScale = transform.localScale + Vector3.one * difference * scaleSpeed;
            newScale = Vector3.Max(newScale, Vector3.one * minScale);
            newScale = Vector3.Min(newScale, Vector3.one * maxScale);
            transform.localScale = newScale;
        }
    }
}