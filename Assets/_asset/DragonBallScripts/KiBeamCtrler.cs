using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiBeamCtrler : StatesController
{
    [SerializeField] GameObject beamChargePrefarb, kiBeamPrefab;
    [SerializeField] Transform BeamShotPosition;

    public void CreatBeamCharge()
    {
        GameObject beamCharge = Instantiate(beamChargePrefarb, BeamShotPosition.position, BeamShotPosition.rotation);
        beamCharge.GetComponent<BeamCharge>().DoWhenDestroy += ChargeToShoot;
    }

    void ChargeToShoot()
    {
        animHandle.PlayKiBeam(isShoot: true);
        CreatBeam();
    }

    public void CreatBeam()
    {
        GameObject KiBeam = Instantiate(kiBeamPrefab, BeamShotPosition.position, BeamShotPosition.rotation);
        KiBeam.GetComponent<Beam>().DoWhenDestroy += EndState;
    }

    void EndState()
    {
        this.enabled = false;
    }

    private void OnDisable()
    {
        animHandle.PlayKiBeam(isEnd: true);
        GetComponent<ChargeCtrler>().enabled = false;
    }
}
