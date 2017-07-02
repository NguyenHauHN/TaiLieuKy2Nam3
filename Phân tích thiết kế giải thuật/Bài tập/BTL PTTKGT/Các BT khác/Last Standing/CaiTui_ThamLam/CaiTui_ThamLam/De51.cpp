// de 5 bai toan cai tui theo phuong phap tham lam
#include<iostream>
using namespace std;

struct Dovat
{
	int c;
	int w;
};

void Caitui(Dovat a[], int n, int b)
{
	Dovat t;
	for (int i = 0; i<n; i++)
	{
		for (int j = n - 1; j>0; j--)
			if (a[j - 1].c*a[j].w < a[j].c*a[j - 1].w)
			{
				t.c = a[j - 1].c; t.w = a[j - 1].w;
				a[j - 1].c = a[j].c; a[j - 1].w = a[j].w;
				a[j].c = t.c; a[j].w = t.w;
			}
	}

	int k = 0;
	int sc = 0; int sw = 0;
	while (b>0 && k<n)
	{
		if (a[k].w <= b)
		{
			cout << "do vat thu " << k << " : " << "gia tri = " << a[k].c << ", trong luong = " << a[k].w << endl;
			b = b - a[k].w;
			sc += a[k].c;
			sw += a[k].w;
		}
		k++;
	}
	cout << "tong gia tri = " << sc << ", tong trong luong = " << sw << endl;
}

main()
{
	Dovat a[] = { { 20,14 },{ 16,6 },{ 8,10 },{ 10,5 },{ 16,6 },{ 28,10 },{ 36,25 },{ 13,8 },{ 9,32 },{ 22,14 } };
	int b;
	cout << "nhap trong luong tui: "; cin >> b;
	Caitui(a, 10, b);

	system("pause");
}
