using UnityEngine;

public class ObjectSetup : MonoBehaviour
{
    public static GameObject VaseLL;
    public static GameObject VaseRL;
    public static GameObject VaseLR;
    public static GameObject VaseRR;
    public static GameObject PaintingLL;
    public static GameObject PaintingRL;
    public static GameObject PaintingLR;
    public static GameObject PaintingRR;
    public static GameObject PhotoGraphLL;
    public static GameObject PhotoGraphRL;
    public static GameObject PhotoGraphLR;
    public static GameObject PhotoGraphRR;

    private void Awake()
    {
        VaseLL = GameObject.Find("Mirrored Objects/VaseLL");
        VaseRL = GameObject.Find("Mirrored Objects/VaseRL");
        VaseLR = GameObject.Find("Mirrored Objects/VaseLR");
        VaseRR = GameObject.Find("Mirrored Objects/VaseRR");

        PaintingLL = GameObject.Find("Mirrored Objects/PaintingLL");
        PaintingRL = GameObject.Find("Mirrored Objects/PaintingRL");
        PaintingLR = GameObject.Find("Mirrored Objects/PaintingLR");
        PaintingRR = GameObject.Find("Mirrored Objects/PaintingRR");

        PhotoGraphLL = GameObject.Find("Mirrored Objects/PhotoGraphLL");
        PhotoGraphRL = GameObject.Find("Mirrored Objects/PhotoGraphRL");
        PhotoGraphLR = GameObject.Find("Mirrored Objects/PhotoGraphLR");
        PhotoGraphRR = GameObject.Find("Mirrored Objects/PhotoGraphRR");

        VaseLL.SetActive(false);
        VaseRL.SetActive(true);
        VaseLR.SetActive(true);
        VaseRR.SetActive(false);

        PaintingLL.SetActive(false);
        PaintingRL.SetActive(true);
        PaintingLR.SetActive(false);
        PaintingRR.SetActive(true);

        PhotoGraphLL.SetActive(true);
        PhotoGraphRL.SetActive(false);
        PhotoGraphLR.SetActive(true);
        PhotoGraphRR.SetActive(false);
    }
}
