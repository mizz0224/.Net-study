#include <iostream>
using namespace std;

class A {
	int num;
public:
	int num2;
	void print_This(){
		cout << "Class A狼 this 林家 : " << this << endl;
	}
	void mul(int a){
		cout << "num * a = "<< this->num2 * a<< endl;
	}

	A* return_A() {
		return this;
	}

};
int main(void) {
	A a,b;
	a.num2 = 2;
	b.num2 = 3;
	
	a.mul(3);
	b.mul(3);

	cout << "a狼 林家蔼 : " << &a << endl; // a instance pointer
	a.print_This();

	cout << "B狼 林家蔼 : " << &b << endl; // a instance pointer
	b.print_This();

	cout << "a狼 林家蔼 : " << &a << endl; // a instance pointer
	return 0;
}