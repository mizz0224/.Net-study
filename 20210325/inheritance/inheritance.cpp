#include <stdio.h>
#include <iostream>
using namespace std;

class A {
    int i;
public:
    A() {
        i=0;
    }
    virtual void Print() { cout << i << endl; } // 가상함수 하위클래스(자식클래스)에서 오버로딩될만한 확률이 높은 상위클래스(자식클래스) 의 함수에 virtual이라고 가상함수로선언
};//class A

class B : public A {
    int i;
public:
    B() {
        i=1;
    }
    void Print() { cout << i << endl; }
};//class B

class C : public B {
    int i;
public:
    C() {
        i=2;
    }
    void Print() { cout << i << endl; }
};//class C

void main() {
    A* ap;
    B b;
    C c;
    ap=&b;//이 문장이 가능한가?
    ap->Print();//가능하다면, 무엇이 호출되는가?
    ap=&c;
    ap->Print();
}//main