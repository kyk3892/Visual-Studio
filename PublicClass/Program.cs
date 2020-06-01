using System;

namespace PublicClass
{
    //외부 클래스의 접근
    class Test
    {
        public void TestMethod()
        {
            //외부 클래스 Main() 메서드는 private이기 때문에 아래와 같이 사용할 수 없음
            // Program.Main(new string[] { "" });
        }
    }
    class Program
    {
        //내부 클래스의 접근
        class Test
        {
            public void TestMethod()
            {
                //내부 클래스이므로 Main() 메서드 사용 가능
                Program.Main(new string[] { "" });
            }
        }
        
        //Main() 메서드는 기본적으로 private 메서드
        static void Main(string[] args)
        {
            
        }
    }
}
