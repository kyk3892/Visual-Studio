using System;

namespace Property
{
    class Program
    {
        class Box
        {
            //변수는 되도록 private을 쓰는게 좋다
            private int width;
            public int Width //속성은 변수도 아니고 함수도 아니다.
            {
                get { return width; }
                set
                {
                    if(value > 0 ) { width = value; }
                    else { Console.WriteLine("너비는 자연수를 입력해주세요"); }
                }
            }

            //보통 변수는 소문자, 속성은 대문자로 써서 구분한다
            private int height;
            public int Height
            {
                get { return height; }
                set
                {
                    if (value > 0) { height = value; }
                    else { Console.WriteLine("높이는 자연수를 입력해주세요"); }
                }
            }
            public int Area() { return this.width * this.height; }
            
            //생성자 생성
            public Box(int width, int height)
            {
                Width = width;
                Height = height;
            }
        }

        static void Main(string[] args)
        {
            Box box = new Box(-10, -20);
            box.Width = -200;
            box.Height = -100;
            
            //속성이지만 변수쓰듯이 쓸 수 있음
            box.Width = 200;
            box.Height = 100;

            Console.WriteLine("box.Height 값 : "+box.Height);
            Console.WriteLine("box.Area()의 값 : "+box.Area());
        }
    }
}
