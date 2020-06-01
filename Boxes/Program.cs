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
            else
            {
                Console.WriteLine("너비와 높이는 자연수로 초기화해주세요!");
            }
        }
        public int Area()
        {
            return this.width * this.height;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            BoxA ba = new BoxA(-3, 6);
            Console.WriteLine("BoxA : "+ba.Area());
            ba.width = -7; //값 변경 가능

            BoxB bb = new BoxB(-3, 6);
            Console.WriteLine("BoxB : "+bb.Area());
            //private이므로 값 변경 불가능
            //bb.width = 3;
        }
    }
}
