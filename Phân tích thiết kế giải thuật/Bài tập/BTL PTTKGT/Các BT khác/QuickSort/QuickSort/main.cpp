#include <stdio.h>
#include <iostream>
using namespace std;

void swap(int& a, int& b) {
	int t;
	t = a;
	a = b;
	b = t;
}
void QuickSort(int A[], int l, int r) {
	int x = A[l];
	int i = l;
	int j = r;
	while (i <= j)
	{
		while (A[i] < x)
		{
			i++;
		}
		while (A[j] > x)
		{
			j--;
		}
		if (i <= j) {
			swap(A[i], A[j]);
			i++;
			j--;
		}
	}
	if (l < j) QuickSort(A, l, j);   // lam lai voi mang a[l]....a[j]
	if (i < r) QuickSort(A, i, r);
}

void Print(int A[]) {
	int i;
	cout << "Ket qua: " << endl;

	for (i = 0; i < 7; i++) {
		cout << A[i] << "\t";
	}
	cout << endl;
}
int main() {
	int A[] = {3,1,7,8,6,2,9};
	QuickSort(A,0, 6);
	Print(A);

	system("pause");
	return 0;
}