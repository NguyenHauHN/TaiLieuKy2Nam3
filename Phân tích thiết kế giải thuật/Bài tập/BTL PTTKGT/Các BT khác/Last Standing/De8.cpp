// de 8 cay khung nho nhat - prim theo phuong phap tham lam
#include<iostream>
#include<float.h>
#define vc INT_MAX
using namespace std;

void Prim(int a[][7], int n, int xuatphat)
{
	int tour[n];
	int daxet[n];
	int min;
	int dinhke;
	int dinhht;
	
	tour[0]=xuatphat;
	daxet[xuatphat]=1;
	
	for(int i=1;i<n;i++)
	{
		min=vc;
		for(int j=0;j<i;j++)
		{
			for(int k=0;k<n;k++)
			if(daxet[k]!=1 && min>a[tour[j]][k])
			{
				min=a[tour[j]][k];
				dinhke=k;
				dinhht=tour[j];
			}
		}
		tour[i]=dinhke;
		daxet[dinhke]=1;
		cout<<dinhht+1<<" -> "<<dinhke+1<<" : "<<min<<endl;
	}
}

main()
{
	int a[][7]={
		{0,1,vc,4,vc,vc,vc},
		{1,0,2,6,6,vc,vc},
		{vc,2,0,vc,4,5,vc},
		{4,6,vc,0,3,vc,4},
		{vc,6,4,3,0,8,7},
		{vc,vc,5,vc,8,0,3},
		{vc,vc,vc,4,7,3,0}
	};
	Prim(a, 7, 0);
}
