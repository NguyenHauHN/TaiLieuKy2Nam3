// de 4 hoan doi m phan tu cuoi cua mang theo phuong phap chia de tri
#include<iostream>
using namespace std;

void Hoandoi(int a[], int i, int j, int m)
{
	for (int k = 0; k<m; k++)
	{
		swap(a[i + k], a[j - m + 1 + k]);
	}
}

void Baitoan(int a[], int n, int m)
{
	if (m >= n) return;
	int i = 0;
	int j = n - 1;
	int t;
	while (i<j)
	{
		if (m == n - m)
		{
			Hoandoi(a, i, j, m);
			break;
		}
		if (m<n - m)
		{
			Hoandoi(a, i, j, m);
			n = n - m;
			j = j - m;
		}
		else
		{
			Hoandoi(a, i, j, n - m);
			i = i + n - m;
			t = n;
			n = m;
			m = m - (t - m);
		}
	}
}

int main()
{
	int a[] = { 1,2,3,4,5,6,7,8,9,10,11,12 };
	int n = 12;
	int m;
	cout << "nhap so phan tu hoan doi: "; cin >> m;
	Baitoan(a, n, m);
	for (int i = 0; i<n; i++)
	{
		cout << a[i] << " ";
	}
	cout << endl;

	system("pause");
	return 0;
}
