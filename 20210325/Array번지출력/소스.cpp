#include <stdio.h>
int main()
{
	int a[4] = { 1, 2, 3, 4 };
	float f[4];
	double d[4];

	printf("%d, %d\n", a[2], *(a + 2));
	printf("%p, %p\n", &a[2], &*(a + 2));
	// a,f,d �� ���� ����غ���
	// for�� �̿��Ͽ� f[4]�� 4���� �׸� ������ ���
	// for�� �̿��Ͽ� d[4]�� 4���� �׸� ������ ���
	//		printf("Address of f[ %d ] =  %p\n", i, &*(f + i));
	printf("a�迭�� �� ���\n");
	for (int i = 0; i < (sizeof(a) / sizeof(int)); i++)
	{
		printf("%d\n", a[i]);
	}
	printf("\n\n\n");
	printf("f�迭�� �� ���\n");
	for (int i = 0; i < (sizeof(f) / sizeof(float)); i++)
	{
		printf("%f\n", f[i]);
	}
	printf("\n\n\n");
	printf("a�迭�� �� ���\n");
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