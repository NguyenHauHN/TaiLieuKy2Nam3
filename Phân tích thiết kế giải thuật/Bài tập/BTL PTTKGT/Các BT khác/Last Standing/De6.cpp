// de 6 bai toan nguoi du lich theo phuong phap tham lam
#include<iostream>
#include<float.h>
using namespace std;

void Dulich(int a[][5], int n, int xuatphat)
{
	int daxet[n];
	int tour[n];
	int min;
	int dinhke;
	int s=0;
	
	tour[0]=xuatphat;
	daxet[xuatphat]=1;
	
	for(int i=1;i<n;i++)
	{
		min=INT_MAX;
		for(int j=0;j<n;j++)
		{
			if(daxet[j]!=1 && min>a[tour[i-1]][j])
			{
				min=a[tour[i-1]][j];
				dinhke=j;
			}
		}
		
		tour[i]=dinhke;
		daxet[dinhke]=1;
		s+=min;
		cout<<tour[i-1]+1<<" -> "<<dinhke+1<<" : "<<min<<endl;
	}
	cout<<tour[n-1]+1<<" -> "<<xuatphat+1<<" : "<<a[tour[n-1]][xuatphat]<<endl;
	s+=a[tour[n-1]][xuatphat];
	cout<<"tong chi phi = "<<s<<endl; 
}

main()
{
	int a[][5]={{0,1,2,7,5},{1,0,4,4,3},{2,4,0,1,2},{7,4,1,0,3},{5,3,2,3,0}};
	Dulich(a, 5, 0);
	system("pause");
}
