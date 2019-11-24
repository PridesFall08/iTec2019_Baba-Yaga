using UnityEngine;

public class BambooHolder : MonoBehaviour
{
    public Bamboo equippedBamboo = null;
    public Transform mouth;
    public Bamboo scannedBamboo = null;

    private RigidbodyController _playerController;

    private void Start()
    {
        _playerController = GetComponent<RigidbodyController>();
    }

    private void EquipBamboo()
    {
        equippedBamboo = scannedBamboo;
        scannedBamboo = null;
        equippedBamboo.Attach(mouth);
        _playerController.speedMultiplier = equippedBamboo.GetSpeedMultiplier();
    }

    private void UnequipBamboo()
    {
        equippedBamboo.Detach(mouth);
        equippedBamboo = null;
        _playerController.ResetSpeedMultiplier();
    }
    
    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (scannedBamboo != null)
            {
                if (equippedBamboo != null)
                    UnequipBamboo();
                else
                    EquipBamboo();    
            }
            else if (equippedBamboo != null)
                UnequipBamboo();
        }
    }
}
