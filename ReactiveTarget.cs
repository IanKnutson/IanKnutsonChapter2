using UnityEngine;
using System.Collections;

public class ReactiveTarget : MonoBehaviour {

    public void ReactToHit() {
        StartCoroutine(Die());
    }
    private IEnumerator Die() {
        this.transform.Rotate(-75, 0, 0);

        yield return new WaitForSeconds(1.5f);

        Destroy(this.gameObject)
    }
}
if (Physics.Raycast(ray, out hit)) {
    GameObject hitObject = hit.transform.gameOjbect;
    ReactivateTarget target = hitObject.GetComponent<ReactivateTarget>();
    if (target !=null) {
       target.ReactToHit();
    } else {
        StartCoroutine(SphereIndicator(hit.point));
    }
}