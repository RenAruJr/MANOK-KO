using UnityEngine;

public class Chicken : Interactable
{
    public override void Interact()
    {
        Debug.Log("You saved the chicken!");
        Destroy(gameObject);
    }
}