#include <iostream>
#define VC 1000
using namespace std;
int Ddnn[7], Daxet[7], L[7];
int  k, Dht, Min;
int n; //so dinh
void Print() {
	int t;
	for (t = 1; t <= n; t++) {
		cout << Ddnn[t] << "-->";
	}
}
void Dijstra(int C[7][7],int s) {
	int i, j = 2, h = 1;
	L[s] = 0;
	Daxet[s] = 1;
	Ddnn[1] = s;
	Dht = s;
	while (h <=n)
	{
		Min = VC;
		for (i = 1; i <= n; i++) {
			if (Daxet[i] == 0) {
				if (L[Dht] + C[Dht][i] < L[i]) {
					L[i] = L[Dht] + C[Dht][i];
					
				}
				if (L[i] < Min) {
					Min = L[i];
					k = i;
				}
			}
			
			
		}
		Dht = k;
		Ddnn[j] = Dht;
		Daxet[Dht] = 1;
		j++;
		h++;
		

	}
	
	
}

int main() {
	int i;
	n = 6;
	int C[7][7] = {
		{ 0, 0, 0, 0, 0, 0 , 0},
		{ 0, 0, 20, 15, VC, 80, VC },
		{ 0, 40, 0, VC, VC, 10, 30 },
		{ 0, 20, 4, 0, VC, VC,10 },
		{ 0, 36, 18, 15, 0, VC, VC },
		{ 0, VC, VC, 90, 15, 0 , VC },
		{ 0, VC, VC, 45, 4, 10 , 0 }
	};
	for (i = 1; i <= n; i++) {
		Daxet[i] = 0;
		L[i] = VC;
	}
	Dijstra(C, 1);
	Print();
	system("pause");
	return 0;
}
