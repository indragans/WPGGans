using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountResources : MonoBehaviour
{
    public int resourcesCount = 0;
    public TextMeshProUGUI countText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countText.text = resourcesCount.ToString();
    }
}
