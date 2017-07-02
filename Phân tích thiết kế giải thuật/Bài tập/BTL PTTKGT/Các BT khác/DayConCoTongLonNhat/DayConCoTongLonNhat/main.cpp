// de 3 day con lien tiep co tong lon nhat theo phuong phap chia de tri
#include<iostream>
#include<float.h>
using namespace std;

int Leftvector(int a[], int l, int r)
{
	int max = INT_MIN;
	int s = 0;
	for (int k = r; k >= l; k--)
	{
		s += a[k];
		max = max>s ? max : s;
	}
	return max;
}

int Rightvector(int a[], int l, int r)
{
	int max = INT_MIN;
	int s = 0;
	for (int k = l; k <= r; k++)
	{
		s += a[k];
		max = max>s ? max : s;
	}
	return max;
}

int Max(int a, int b, int c)
{
	int max = a>b ? a : b;
	return max>c ? max : c;
}

int Daycon(int a[], int l, int r)
{
	if (l == r) return a[l];
	int m = (l + r) / 2;
	int wl = Leftvector(a, l, m);
	int wr = Rightvector(a, m + 1, r);

	return Max(wl, wr, wl + wr);
}

int main()
{
	int a[] = { -98,54,67,65,-879,78,65,21,-6,67 };
	int n = 10;
	cout << "day con lien tiep co trong so lon nhat = " << Daycon(a, 0, n - 1);
	cout << endl;
	system("pause");
	return 0;
}
