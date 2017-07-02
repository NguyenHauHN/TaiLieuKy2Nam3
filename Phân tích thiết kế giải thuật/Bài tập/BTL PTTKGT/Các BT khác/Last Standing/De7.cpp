// de 7 duong di ngan nhat - dijkstra theo phuong phap tham lam
#include<iostream>
#include<float.h>
#define vc INT_MAX
using namespace std;

void Dijkstra(int a[][6], int n, int xuatphat)
{
	int daxet[n];
	int tour[n];
	int min, dinhke;
	
	daxet[xuatphat]=1;
	tour[0]=xuatphat;
	int cost[n];
	for(int k=0;k<n;k++)
	{
		cost[k]=a[xuatphat][k];
	}
	
	for(int i=1;i<n;i++)
	{
		min=vc;
		for(int j=0;j<n;j++)
		{
			if(daxet[j]!=1 && min>cost[j])
			{
				min=cost[j];
				dinhke=j;
			}
		}
		
		tour[i]=dinhke;
		daxet[dinhke]=1;
		for(int k=0;k<n;k++)
		{
			if(cost[dinhke]!=vc && a[dinhke][k]!=vc)
			cost[k]=cost[k]<cost[dinhke]+a[dinhke][k] ? cost[k]: cost[dinhke]+a[dinhke][k];
		}
	}
	
	for(int i=0;i<n;i++)
	{
		for(int j=0;j<=i;j++)
		{
			cout<<tour[j]+1<<" ";
		}
		cout<<": "<<cost[tour[i]]<<endl;
	}
}


main()
{
	int a[][6]={
		{0,20,15,vc,80,vc},
		{40,0,vc,vc,10,30},
		{20,4,0,vc,vc,10},
		{36,18,15,0,vc,vc},
		{vc,vc,90,15,0,vc},
		{vc,vc,45,4,10,0}
	};
	Dijkstra(a, 6, 0);
	system("pause");
}
