//[1] 네임 스페이스 선언부
using UnityEngine; // 현재 CSharp File에서 UnityEngine NameSpace를 사용

//[2] 클래스 선언부
public class HelloWorld : MonoBehaviour
{
    //[3] Start 메서드 선언, 정의 : 프로그램을 시작할때 1번만 실행
    void Start()
    {
        //[5] 명령문 : 콘솔창에 출력하라
        Debug.Log(string.Format("Hello World"));
    }

    //[4] Update 메서드 선언, 정의
    void Update()
    {
        
    }
}
