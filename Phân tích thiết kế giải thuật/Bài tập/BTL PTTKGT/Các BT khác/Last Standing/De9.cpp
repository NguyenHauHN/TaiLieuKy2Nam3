// de 9 cay khung nho nhat - kruskal theo phuong phap tham lam
#include<iostream>
#include<float.h>
#define vc INT_MAX
using namespace std;

void Kruskal(int a[][7], int n)
{
	int cay[n];
	for(int i=0;i<n;i++)
	{
		cay[i]=i;
	}
	int min;
	int dinhht;
	int dinhke;
	int x, s=0;
	for(int i=0;i<n-1;i++)
	{
		min=vc;
		for(int j=0;j<n;j++)
		{
			for(int k=0;k<n;k++)
			{
				if(cay[j]!=cay[k] && a[j][k]!=0 && min>a[j][k])
				{
					min=a[j][k];
					dinhht=j;
					dinhke=k;
				}
			}
		}
		x=cay[dinhht];

		for(int t=0;t<n;t++)
		{
			if(cay[t]==x)
			{
				cay[t]=cay[dinhke];
			}
		}

		cout<<dinhht+1<<" -> "<<dinhke+1<<" : "<<min<<endl;
		s+=min;
	}
	cout<<endl<<"tong trong so cay khung = "<<s<<endl;
}

main()
{
	
	int a[][7]={
		{0,3,vc,1,vc,3,vc},
		{3,0,4,vc,vc,6,vc},
		{vc,4,0,3,7,vc,5},
		{1,vc,3,0,6,2,vc},
		{vc,vc,7,6,0,5,vc},
		{3,6,vc,2,5,vc,1},
		{vc,vc,5,vc,vc,1,0}
	};
	/*
	int a[][7]={
		{0,1,vc,4,vc,vc,vc},
		{1,0,2,6,6,vc,vc},
		{vc,2,0,vc,4,5,vc},
		{4,6,vc,0,3,vc,4},
		{vc,6,4,3,0,8,7},
		{vc,vc,5,vc,8,0,3},
		{vc,vc,vc,4,7,3,0}
	};
	*/
	Kruskal(a, 7);
	
	system("pause");
}
