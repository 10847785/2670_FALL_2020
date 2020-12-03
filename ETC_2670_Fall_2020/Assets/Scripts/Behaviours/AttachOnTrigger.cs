using UnityEngine;

public partial class AttachOnTrigger : MonoBehaviour
{
    public StringData tagObj;
    public ID idObj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagObj.value)) return;
        // var newObj = GetComponent<IDHolder>().ideObj;
        //  if (newObj == null) return;
        transform.parent = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        transform.parent = null;
    }
}
