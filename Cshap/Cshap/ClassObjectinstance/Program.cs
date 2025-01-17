﻿using System;
using System.Runtime.InteropServices;

namespace ClassObjectinstance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // new 키워드
            // 동적할당 키워드
            // 객체화 : 클래스타입의 멤버들만큼의 변수공간을 할당하는 과정
            // 객체 : 클래스타입의 멤버들만큼 할당된 메모리 공간
            // 인스턴스화 : 객체의 실제 데이터를 대입하는 과정
            // 인스턴스 : 객체는 객체인데, 각 멤버들의 데이터가 초기화되어있는 상태의 객체

            // C# 에서 생성자를 호출하는 과정이 객체화 이면서 인스턴스화 이다.
            // 인스턴스 ⊂ 객체
            Human human = new Human();

            // .연산자 
            // 멤버접근 연산자 
            human.height = 150.0f;
            human.name = "홍길동";
            human.Breath();
            Console.WriteLine(human.height);
            Console.WriteLine($"성별 : {human.genderCharacter}");

            // 객체의 멤버변수는 초기호값이 없을경우
            // BBS 영역에 저장되며, 해당 영역은 모든비트가 0으로 세팅되기때문에
            // 지역변수처럼 반드시 초기화를 할 필요가 없다.
            // tempChar;
            // Console.WriteLine($"성별 : {tempChar}");

            Console.WriteLine(Human.instance.name);


            Human human2 = new Human();
            human2.height = 160.0f;
            human2.name = "만수";
            human2.Breath();

            //Human.instance

        }
    }
    // 클래스도 사용자정의 '자료형'
    public class Human
    {
        // static 키워드
        // 객체화가 불가능한 키워드 --> human 클래스타입의 객체를 만들었을때 해당 객체는 instance 라는 멤버변수가 없다
        public static Human instance;

        // 보호수준을 결정하는 접근 제한자
        // public : 접근 제한 없음
        // private : 해당 객체 외 접근 제한
        // protected : 해당객체 및 자식객체 외 접근 제한
        // internal : 동일 어셈블리(프로젝트) 외 접근 제한
        // class 의 멤버들에게 접근제한자를 명시하지 않을겨우
        // private 이 기본값임.
        public int age = 1;
        public float height;
        public double weight;
        public bool isReseting;
        public char genderCharacter;
        public string name;
        
        // 생성자
        // 객체를 생성하는 함수
        // 객체를 생성한다는 의미: 해당 클래스타입의 멤버들을 위한 메모리공간을 전부 확보함.
        // 생성자도 기본적으로 함수 
        // 반환형은 힙 영역에 동적할당한 객체의 참조
        
        // 참조란?
        // 특정 메모리의 주소를 가지고 있으며 해당 주소의 데이터를 읽고 쓸 수 있느 형태

        // 값 형식과 vs 참조 형식
        // 값 형식 : 스택영역에 데이터가 할당됨.
        // ex) int, float, double, char, struct....
        // 참조 형식 : 힙영역에 데이터가 할당됨.
        // ex) class, array, string....

        public Human()
        {
            // this 키워드
            // 객체 자기자신 참조 반환키워드
            Console.WriteLine(Human.instance = this);

            this.height = 160.0f;
            this.weight = 300.0f;
            this.isReseting = false;

        }
        
        // 소멸자
        // 해당 객체를 메모리에서 해제할때 호출하는 함수
        // 가비지컬렉터가 행당 객체가 참조되지 않을경우 호줄해주기 때문에 직접 호출하는 일은 없다.
        ~Human()
        {

        }

        public void Breath()
        {
            Console.WriteLine($"{this.name} (이)가 숨을 쉰다");
        }
    }
}

