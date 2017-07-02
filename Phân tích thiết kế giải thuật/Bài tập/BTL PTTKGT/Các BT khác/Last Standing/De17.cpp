// de 17 - bai toan ngua di tuan
#include<iostream>
using namespace std;

void Print(int h[50][50], int n)
{
	cout<<"Ket qua: \n";
	for(int i=0;i<n;i++)
	{
		for(int j=0;j<n;j++)
		{
			cout<<h[i][j]<<"\t";
		}
		cout<<endl;
	}
}

void Try(int h[50][50], int a[], int b[], int n, int i, int x, int y)
{
	if(i<=n*n)
	{
		int u,v, k;
		for(k=0;k<n;k++)
		{
			u=x+a[k];
			v=y+b[k];
			if((u>=0 && u<n) && (v>=0 && v<n) && h[u][v]==0)
			{
				h[u][v]=i;
				if(i<=n*n)
					Try(h, a, b, n, i+1, u, v);
					
				// tra lai gia tri
				h[u][v]=0;
			}
		}
		if(k==n) return;
	}
	else 
	{
		Print(h, n);
	}
}

main()
{
	cout<<"Nhap so o: "; int n; cin>>n;
	int a[]={1,2,2,1,-1,-2,-2,-1}; 	// toa do x
	int b[]={2,1,-1,-2,-2,-1,1,2}; 	// toa do y
	int h[50][50];
	for(int i=0;i<n;i++)
	{
		for(int j=0;j<n;j++)
			h[i][j]=0;
	}
	cout<<"Nhap vi tri x: "; int x; cin>>x;
	cout<<"Nhap vi tri y: "; int y; cin>>y;
	h[x][y]=1;
	Try(h, a, b, n, 2, x, y);
	
	system("pause");
}
