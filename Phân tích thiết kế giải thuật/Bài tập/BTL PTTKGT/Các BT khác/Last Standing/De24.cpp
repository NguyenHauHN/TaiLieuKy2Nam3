#include<iostream>
#include<fstream>
using namespace std;

main()
{
	ifstream f;
	f.open("input");
	int n;
	while(!f.eof())
	{
		f>>n;
		cout<<n<<" ";
	}	
	f.close();
	
	cout<<endl;
}
