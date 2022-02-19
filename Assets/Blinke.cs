using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OscCore;

public class Blinke : MonoBehaviour
{
    // Start is called before the first frame update
    public float[] Blendersheapes = new float[51];
    
    public SkinnedMeshRenderer face;
    string m_Address = "/avatar/parameters/";
    OscClient Client = new OscClient("127.0.0.1", 9000);
   
    // Update is called once per frame
    void Update()
    {
        
        for (int i = 0;i < 51; i++)
        {
            float n = face.GetBlendShapeWeight(i) / 100;
            Client.Send(m_Address+i.ToString(), n);

        }
        //var value = propertyOutput.m_MemberIsProperty ? propertyOutput.m_Property.GetValue(propertyOutput.m_SourceComponent) : propertyOutput.m_Field.GetValue(propertyOutput.m_SourceComponent);
       
        

    }
    
}
