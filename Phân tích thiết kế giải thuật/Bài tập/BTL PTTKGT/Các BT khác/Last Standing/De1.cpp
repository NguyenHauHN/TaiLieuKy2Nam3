// de 1 thuat toan quicksort theo phuong phap chia de tri
#include<iostream>
using namespace std;

void Quicksort(int a[], int l, int r)
{
	if(l>=r) return;
	int i=l+1;
	int j=r;
	int x=a[l];
	while(i<j)
	{
		while(i<j && a[i]<x) i++;
		while(j>=i && a[j]>=x) j--;
		if(i<j)
		{
			swap(a[i], a[j]);
			i++;
			j--;
		}
	}
	if(i!=j)
	{
		a[l]=a[j];
		a[j]=x;
	}
	Quicksort(a, l, j-1);
	Quicksort(a, j+1, r);
}

main()
{
	int a[]={3,5,8,9,4,2,7,5,3,8,9};
	int n=11;
	Quicksort(a, 0, n-1);
	for(int i=0;i<n;i++)
		cout<<a[i]<<" ";
	cout<<endl;
	
	system("pause");
}
