#include <iostream>
using namespace std;
void swap(int& a, int& b) {
	int t;
	t = a;
	a = b;
	b = t;
}
void Merge(int A[], int l, int r, int m) {
	int i, length, j, p;
	i = l;
	j = m + 1;
	p = l;
	int c[7];
	while (i <= m && j <= r)
	{
		if (A[i] <= A[j]) {
			c[p] = A[i];
			i++;
		}
		else {
			c[p] = A[j];
			j++;
		}
		p++;
	}
	// neu mang dau tien chua het
	while (i <= m)
	{
		c[p] = A[i];
		i++;
		p++;
	}
	//neu mang thu 2 chua het
	while (j<=r)
	{
		c[p] = A[j];
		j++;
		p++;
	}

	for (i = l; i <= r; i++) {
		A[i] = c[i];
	}

}
void MergeSort(int A[], int l, int r) {
	int m;
	if (l < r) {
		m = (l + r) / 2;
		MergeSort(A, l, m);
		MergeSort(A, m + 1, r);
		Merge(A, l, r, m);
	}
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
	int A[] = { 3,1,7,8,6,2,9 };
	MergeSort(A, 0, 6);
	Print(A);
	system("pause");
	return 0;
}