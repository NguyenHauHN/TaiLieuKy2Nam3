// de 2 thuat toan merge sort theo phuong phap chia de tri
#include<iostream>
using namespace std;

void Merge(int a[], int l, int m, int r)
{
	int b[r-l+1];
	int i=l, j=m+1, p=0;
	while(i<=m && j<=r)
	{
		if(a[i]<a[j])
		{
			b[p]=a[i];
			i++;
		}
		else
		{
			b[p]=a[j];
			j++;
		}
		p++;
	}
	while(i<=m)
	{
		b[p]=a[i];
		i++;
		p++;
	}
	while(j<=r)
	{
		b[p]=a[j];
		j++;
		p++;
	}
	
	for(int k=0;k<r-l+1;k++)
	{
		a[l+k] = b[k];
	}
}

void Mergesort(int a[], int l, int r)
{
	if(l>=r) return;
	int m=(l+r)/2;
	Mergesort(a, l, m);
	Mergesort(a, m+1, r);
	Merge(a, l, m, r);
}

main()
{
	int a[]={3,5,8,9,4,2,7,5,3,8,9};
	int n=11;
	Mergesort(a, 0, n-1);
	for(int i=0;i<n;i++)
	{
		cout<<a[i]<<" ";
	}
	cout<<endl;
	
	system("pause");
}
