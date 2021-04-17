#include <stdio.h>
int main()
{
	int a[4] = { 1, 2, 3, 4 };
	float f[4];
	double d[4];

	printf("%d, %d\n", a[2], *(a + 2));
	printf("%p, %p\n", &a[2], &*(a + 2));
	// a,f,d 의 값을 출력해보기
	// for를 이용하여 f[4]의 4개의 항목 번지를 출력
	// for를 이용하여 d[4]의 4개의 항목 번지를 출력
	//		printf("Address of f[ %d ] =  %p\n", i, &*(f + i));
	printf("a배열의 값 출력\n");
	for (int i = 0; i < (sizeof(a) / sizeof(int)); i++)
	{
		printf("%d\n", a[i]);
	}
	printf("\n\n\n");
	printf("f배열의 값 출력\n");
	for (int i = 0; i < (sizeof(f) / sizeof(float)); i++)
	{
		printf("%f\n", f[i]);
	}
	printf("\n\n\n");
	printf("a배열의 값 출력\n");
	for (int i = 0; i < (sizeof(d) / sizeof(double)); i++)
	{
		printf("%f\n", d[i]);
	}
	printf("\n\n\n");
	for (int i = 0; i < (sizeof(a) / sizeof(int)); i++)
	{
		printf("Address of a[ %d ] =  %p\n\n", i, &*(a + i));
	}
	for (int i = 0; i < (sizeof(f) / sizeof(float)); i++)
	{
		printf("Address of f[ %d ] =  %p\n\n", i, &*(f + i));
	}
	for (int i = 0; i < (sizeof(d) / sizeof(double)); i++)
	{
		printf("Address of d[ %d ] =  %p\n\n", i, &*(d + i));
	}
	return 0;

}