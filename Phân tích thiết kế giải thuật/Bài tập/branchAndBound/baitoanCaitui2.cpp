//#include  <stdio.h>
//#include  <iostream>
//using namespace std;
//int m, n, tong, max1, giatri, check[100];
//struct balo {
//	int kichthuoc;
//	int giatri;
//};
//balo Balo[100];
//void input() {
//	m = 100;  n = 5;  int i;
//	printf("Kich thuoc cai Balo la: %d \n", m);
//	printf("So do vat la: %d \n", n);
//	int a1[] = { 39, 17, 55, 200, 77 };
//	int a2[] = { 99, 95, 31, 62, 90 };
//	for (i = 0; i < n; i++) {
//		Balo[i].giatri = a1[i];
//		Balo[i].kichthuoc = a2[i];
//		check[i] = 0;
//		printf("Vat thu [%d] co gia tri la %d va trong luong %d \n", i, a1[i], a2[i]);
//	}
//}
//void duyet(int v) {
//	printf("v = %d \n", v);
//	for (int i = 0; i < n; i++)
//		if (tong + Balo[i].kichthuoc <= m) {
//			tong = tong + Balo[i].kichthuoc;
//			giatri = giatri + Balo[i].giatri;  check[i] = 1;
//			printf("check[%d] = %d  ", i, check[i]);
//			if (giatri > max1)
//				max1 = giatri;
//			duyet(v + 1);
//			check[i] = 0;
//			printf("check[%d] = %d  ", i, check[i]);
//			tong = tong - Balo[i].kichthuoc;
//			giatri = giatri - Balo[i].giatri;
//		}
//}
////int main() {
////	tong = 0;  int i;
////	giatri = 0;
////	max1 = 0;
////	input();
////	duyet(1);
////	printf("\n Gia tri lon nhat co the cam theo la: %d \n", max1);
////	printf("Cac do vat da chon la: \n");
////	for (i = 0; i < n; i++) {
////		printf("check[%d] = %d \n", i, check[i]);
////		if (check[i] == 1)
////			printf("%5d", i);
////	}
////	return 0;
////}