#include <stdio.h>
#include <iostream>
using namespace std;

class A {
    int i;
public:
    A() {
        i=0;
    }
    virtual void Print() { cout << i << endl; } // �����Լ� ����Ŭ����(�ڽ�Ŭ����)���� �����ε��ɸ��� Ȯ���� ���� ����Ŭ����(�ڽ�Ŭ����) �� �Լ��� virtual�̶�� �����Լ��μ���
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
    ap=&b;//�� ������ �����Ѱ�?
    ap->Print();//�����ϴٸ�, ������ ȣ��Ǵ°�?
    ap=&c;
    ap->Print();
}//main