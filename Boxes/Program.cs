using System;

namespace Boxes
{
    class BoxA
    {
        public int width;
        public int height;
        
        public BoxA(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public int Area()
        {
            return this.width * this.height;
        }
    }

    //변수 width와 height를 건드리지 못하게 수정
    //현재 width,height의 값을 읽을 방법도 없다는 단점
    class BoxB
    {
        private int width;
        private int height;

        public BoxB(int width, int height)
        {
            if(width>0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else { Console.WriteLine("너비와 높이는 자연수로 초기화해주세요!"); }
        }
        public int Area()
        {
            return this.width * this.height;
        }
    }

    class BoxC
    {
        private int width;
        private int height;

        public BoxC(int width, int height)
        {
            if (width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else { Console.WriteLine("너비와 높이는 자연수로 초기화해주세요!"); }
        }
        //인스턴스 메서드
        public int Area() { return this.width * this.height; }

        //겟터 메서드를 사용해 멤버변수를 셋팅
        public int GetWidth() { return width; } //위에 private int width;는 못읽지만 리턴값으로 불러올 수 있음
        public int GetHeight() { return height; }

        //셋터 (읽고 쓰고 계산할 수 있음)
        public void SetWidth(int width)
        {
            if (width > 0) { this.width = width; }
            else { Console.WriteLine("너비와 높이는 자연수로 초기화해주세요!"); }
        }
        public void SetHeight(int height)
        {
            if (height > 0) { this.height = height; }
            else { Console.WriteLine("너비와 높이는 자연수로 초기화해주세요!"); }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ba의 결과");
            BoxA ba = new BoxA(-3, 6);
            Console.WriteLine("BoxA : "+ba.Area());
            ba.width = -7; //값 변경 가능

            Console.WriteLine("\nbb의 결과");
            BoxB bb = new BoxB(-3, 6);
            Console.WriteLine("BoxB : "+bb.Area());
            //private이므로 값 변경 불가능
            //bb.width = 3;

            Console.WriteLine("\nbc의 결과");
            BoxC bc = new BoxC(3, 5);
            bc.SetWidth(8); //넣어준 값이 잘 들어감
            bc.SetHeight(8);
            int width = bc.GetWidth();
            int height = bc.GetHeight();
            Console.WriteLine(width);
            Console.WriteLine(height);
            Console.WriteLine(bc.Area());

        }
    }
}
