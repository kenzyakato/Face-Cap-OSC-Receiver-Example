using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OscCore;

public class Blinke : MonoBehaviour
{
    // Start is called before the first frame update
    //トラキングされてる顔の指定
    public SkinnedMeshRenderer face;
    //VRChatのアバターパラメータのアドレスとポートの設定
    string m_Address = "/avatar/parameters/";
    OscClient Client = new OscClient("127.0.0.1", 9000);
    
    // Update is called once per frame
    void Update()
    {
        //目のトラキング値を取得する
        float L = -face.GetBlendShapeWeight(12) / 100;
        float R = face.GetBlendShapeWeight(13) / 100;
        float UP = face.GetBlendShapeWeight(16)/100;
        float DOWN = -face.GetBlendShapeWeight(10)/100;
        //目のトラキング値を発送する
        Client.Send(m_Address + "X", R + L);
        Client.Send(m_Address + "Y", UP + DOWN);
        //顔を制御　対応するblendshapesを制御する
        Client.Send(m_Address + 0.ToString(), face.GetBlendShapeWeight(0) / 100);
        Client.Send(m_Address + 1.ToString(), face.GetBlendShapeWeight(1) / 100);
        Client.Send(m_Address + 2.ToString(), face.GetBlendShapeWeight(2) / 100);
        Client.Send(m_Address + 7.ToString(), face.GetBlendShapeWeight(7) / 100);
        Client.Send(m_Address + 6.ToString(), face.GetBlendShapeWeight(6) / 100);
        Client.Send(m_Address + 8.ToString(), face.GetBlendShapeWeight(8) / 100);
        Client.Send(m_Address + 9.ToString(), face.GetBlendShapeWeight(9) / 100);
        Client.Send(m_Address + 44.ToString(), face.GetBlendShapeWeight(44) / 100);
        Client.Send(m_Address + 43.ToString(), face.GetBlendShapeWeight(43) / 100);
        Client.Send(m_Address + 23.ToString(), face.GetBlendShapeWeight(24) / 100);
        //連続のBlendshapesを制御

        Client.Send(m_Address + 24.ToString(), face.GetBlendShapeWeight(24) / 100);
        //連続のBlendKeyを制御

        for (int i = 18;i < 23; i++)
        {
            float n = face.GetBlendShapeWeight(i) / 100;

            Client.Send(m_Address + i.ToString(), n);
        }

        //var value = propertyOutput.m_MemberIsProperty ? propertyOutput.m_Property.GetValue(propertyOutput.m_SourceComponent) : propertyOutput.m_Field.GetValue(propertyOutput.m_SourceComponent);



    }
    
}
