using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Animation))]
public class StartBarrier : MonoBehaviour
{
   private Animation animation;

   private void Awake()
   {
      animation = GetComponent<Animation>();
      animation.Stop();
      var timeout = Random.Range(0f, 2f);
      StartCoroutine(StartAnimation(timeout));
   }

   private IEnumerator StartAnimation(float time)
   {
      yield return new WaitForSeconds(time);
      animation.Play();
   }


}
