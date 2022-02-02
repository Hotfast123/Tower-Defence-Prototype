using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public IEnumerator CameraShake(float shakeLength, float shakeStrength)
    {
        yield return new WaitForSeconds(0.5f);
        
        //Get orginal postion of camera to return to 
        Vector3 cameraOriginalPos = transform.localPosition;

        float currentShakeTime = 0.0f;

        while (currentShakeTime < shakeLength)
        {
            //Move Camera in shake directions
            float x = Random.Range(-1f, 1f) * shakeStrength;
            float y = Random.Range(-1f, 1f) * shakeStrength;

            transform.localPosition = new Vector3(x, y, cameraOriginalPos.z);

            currentShakeTime += Time.deltaTime;

            yield return null;
        }
        //Return camera to defult postion
        transform.localPosition = cameraOriginalPos;
    }
}

