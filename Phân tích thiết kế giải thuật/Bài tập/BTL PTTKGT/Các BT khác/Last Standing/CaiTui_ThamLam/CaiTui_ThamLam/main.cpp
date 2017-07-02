#include <iostream>
using namespace std;
struct DoVat
{
	int c;
	int w;
};
// thuat toan merge sort
void Merge(DoVat A[], int l, int r, int m) {
	int i, length, j, p;
	i = l;
	j = m + 1;
	p = l;
	DoVat Temp[10];
	while (i <= m && j <= r)
	{
		if (A[i].c >= A[j].c) {
			Temp[p] = A[i];
			i++;
		}
		else {
			Temp[p] = A[j];
			j++;
		}
		p++;
	}
	// neu mang dau tien chua het
	while (i <= m)
	{
		Temp[p] = A[i];
		i++;
		p++;
	}
	//neu mang thu 2 chua het
	while (j <= r)
	{
		Temp[p] = A[j];
		j++;
		p++;
	}

	for (i = l; i <= r; i++) {
		A[i] = Temp[i];
	}

}

void MergeSort(DoVat A[], int l, int r) {
	int m;
	if (l < r) {
		m = (l + r) / 2;
		MergeSort(A, l, m);
		MergeSort(A, m + 1, r);
		Merge(A, l, r, m);
	}
}

void CaiTui(int b, int n, DoVat a[], DoVat result[]) {
	int i , p =0;
	int Sum = 0;
	int GiaTri = 0;
	for (i = 0; i < n; i++) {
		Sum = Sum + a[i].w;
		if (Sum <= b) {
			
			result[p] = a[i];
			GiaTri = GiaTri + a[i].c;
			p++;
			cout << "{" << a[i].c << ", " << a[i].w << "}" << endl;
		}
		else {
			Sum = Sum - a[i].w;
		}
		
	}
	cout << "Tong trong luong do vat lay duoc: " << Sum << endl;
	cout << "Gia tri do vat lay duoc: " << GiaTri << endl;
}
int main() {
	DoVat a[] = { { 7,3 },{ 10,4 },{ 20,5 },{ 19,7 },{ 13,6 },{ 40,9 }};
	DoVat result[10];
	int b;
	cout << "Nhap trong luong tui: ";
	cin >> b;
	MergeSort(a, 0, 5);
	CaiTui(b, 6, a, result);
	system("pause");
	return 0;
}
