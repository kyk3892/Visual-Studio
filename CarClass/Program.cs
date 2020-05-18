using System;

namespace CarClass
{
    class Car //클래스 만들기 클래스는 변수와 메서드로 구성되어 있다.
    {
        string color="red"; //앞에 아무것도 없으면 private적용
        int number=7777;
        public int tires = 4; //외부에서 값을 바꿀 수 있도록 허용

        public void Stop() 
        {

        }
        public void Drive() 
        {

        }
        public void Fly() 
        {
            this.color = "blue";
        }

        public void ShowColor()
        {
            Console.WriteLine(this.color);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car minicar = new Car();
            
            minicar.ShowColor(); //처음의 색상을 보기 위해 red 나와야함

            minicar.Fly(); //Fly() 메서드 실행

            minicar.ShowColor(); //바뀌고 난 뒤의 색상 보기 위해 blue 나와야함

            minicar.tires = 3;
        }
    }
}
