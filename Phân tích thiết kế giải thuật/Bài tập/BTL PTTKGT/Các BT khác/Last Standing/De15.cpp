// de 15 tim duong di ngan nhat - floyd theo phuong phap chia de tri
#include<iostream>
#include<fstream>
#include<float.h>
#define vc INT_MAX
using namespace std;

void Docfile(int d[][10])
{
	fstream f;
	f.open("file.txt", ios::in);
}

void Inkq(int p[][10], int s, int e)
{
	if(p[s][e]!=-1)
	{
		Inkq(p, s, p[s][e]);
		Inkq(p, p[s][e], e);
	}
	else cout<<s+1<<" -> ";
}

void Floyd(int d[][10], int p[][10], int n)
{
	for(int i=0; i<n; i++)
	{
		for(int j=0; j<n; j++)
		{
			p[i][j] = -1;
		}
	}
	
	
	for(int k=0; k<n; k++)
	{
		for(int i=0; i<n; i++)
		{
			if(i != k && d[i][k]!=vc)
			for(int j=0; j<n; j++)
			{
				if(j != k && d[k][j]!=vc && d[i][k] + d[k][j] < d[i][j])
				{
					d[i][j] = d[i][k] + d[k][j];
					p[i][j] = k;
				}
			}
		}
		
		cout<<endl<<"TEST: k = "<<k+1<<"\n";
		for(int i=0;i<n;i++)
		{
			for(int j=0;j<n;j++)
			{
				cout<<p[i][j]+1<<"\t";
			}
			cout<<endl;
		}
	}
}

main()
{
	int d[][10]={
		{ 0 , 3 , 5 , 2 , vc, vc, vc, vc, vc, vc },
		{ 3 , 0 , 5 , vc, vc, vc, vc, vc, vc, 7  },
		{ 5 , 5 , 0 , 4 , vc, 1 , vc, vc, vc, vc },
		{ 2 , vc, 4 , 0 , vc, vc, vc, 2 , vc, vc },
		{ vc, vc, vc, vc, 0 , 5 , vc, vc, vc, 2  },
		{ vc, vc, 1 , vc, 5 , 0 , 6 , 2 , 4 , vc },
		{ vc, vc, vc, vc, vc, 6 , 0 , vc, 5 , 3  },
		{ vc, vc, vc, 2 , vc, 2 , vc, 0 , 6 , vc },
		{ vc, vc, vc, vc, vc, 4 , 5 , 6 , 0 , vc },
		{ vc, 7 , vc, vc, 2 , vc, 3 , vc, vc, 0  }
	};
	
	int n=10;
	int p[10][10];
	Floyd(d, p, n);
	
	cout<<endl<<endl;
	for(int s=0; s<9; s++)
	{
		for(int e=s+1; e<10; e++)
		{
			cout<<"Duong di ngan nhat tu "<<s+1<<" den "<<e+1<<" la: ";
			Inkq(p, s, e);
			cout<<e+1<<"\t\t"<<" - chi phi = "<<d[s][e]<<endl<<endl;
		}
	}
	
	
	system("pause");
}
