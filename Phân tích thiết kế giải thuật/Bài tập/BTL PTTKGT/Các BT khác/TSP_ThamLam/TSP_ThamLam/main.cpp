#include <iostream>
#define MAX 1000
using namespace std;

int v, // dinh hien tai
	k, i, // bien duyet qua n dinh
	w,  // dinh duoc chon qua moi buoc
	CMin, // canh nho nhat duoc chon qua moi buoc
	COST, // Trong so nho nhat cua chu trinh
	Daxet[10], // danh dau trang thai dinh
	TOUR[10], // chu trinh
	n; // so dinh
int GTS(int C[6][6],int n) {
	while (i < n)
	{
		CMin = MAX;
		for (k = 1; k <= n; k++) {
			if (Daxet[k] == 0) {
				if (C[v][k] < CMin) {
					CMin = C[v][k];
					w = k;
				}
			}
		}
		v = w;
		i++;
		TOUR[i] = v;
		Daxet[v] = 1;
		COST += CMin;
			 
	}
	COST += C[v][1];
	return COST;
}
void Print() {
	int j;
	cout << "Chu trinh tim duoc: " << endl;
	for (j = 1; j <= n; j++) {
		
		if (j == n) {
			cout << TOUR[j] << " --> 1";
		}
		else {
			cout << TOUR[j] << "--> ";
		}
	}
	cout << endl;
	cout << "Trong so cua chu trinh: " << COST << endl;
}
int main() {
	
	COST = 0;
	i = 1;
	v = 1;
	TOUR[i] = v;
	for (k = 1; k <= n; k++) {
		Daxet[k] = 0;
	}
	Daxet[v] = 1;
	int C[6][6] = {
		{0, 0, 0, 0, 0, 0},
		{0, 0, 1, 2, 7, 5},
		{0, 1, 0, 4, 4, 3},
		{0, 2, 4, 0, 1, 2},
		{0, 7, 4, 1, 0, 3},
		{0, 5, 3, 2, 3, 0}
	};
	n = 5;
	GTS(C, 5);
	Print();
	system("pause");
	return 0;
}