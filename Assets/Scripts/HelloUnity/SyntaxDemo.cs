using UnityEngine;

//문법(syntax) : 문법은 반드시 지켜야 한다
//코딩컨벤션(코딩스타일) : 프래그래밍 작성 가이드, 약속

public class SyntaxDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //들여쓰기
        Debug.Log("들여쓰기는 공 4칸 또는 탭을 사용한다");

        //공백(white space) : c#에서는 공백 무시
        Debug.Log("c#");
        Debug.Log( "c#" );
        Debug.
            Log 
            (
            "c#"
            );
    }


}
