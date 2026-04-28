using UnityEngine;

//숫자 데이터 형식 사용하기 : 정수형, 실수형
//정수형 (Integer)
public class IntegerDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SignedInteger : (+,-) 부호가 있는 정수형 데이터 형식
        sbyte iSbyte = 127;
        short iInt16 = 32767;
        int iInt32 = 2147483647;
        long iInt64 = long.MaxValue;

        Debug.Log(string.Format("sbyte : {0}\n short : {1}\n int : {2}\n long : {3}",iSbyte,iInt16,iInt32,iInt64));

        //UnSignedInteger : (+,-) 부호가 없는 정수형 데이터 형식

    }


}

/*
1Byte >  8bit
1비트 : 0, 1 데이터를 저장하는 단위

8비트
0000 0000  -> 0
0000 0001  -> 1

sbyte : -128 ~127
byte : 0 ~ 255

*/