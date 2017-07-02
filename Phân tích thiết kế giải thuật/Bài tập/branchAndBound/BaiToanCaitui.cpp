//#include<iostream>
//using namespace std;
//
//int m, n, tong, maxd, giatri;
//typedef struct balo
//{
//	int kichthuoc;
//	int giatri;
//
//};
//balo Balo[100];
//void input()
//{
//	cout << "Nhap kich thuoc cua cai tui: ";
//	cin >> m;
//	cout << "Nhap so luong do vat: ";
//	cin >> n;
//	for (int i = 0; i<n; i++)
//	{
//		cout << "nhap kich thuoc vat thu " << i << " :";
//		cin >> Balo[i].kichthuoc;
//		cout << "nhap gia tri vat thu " << i << " :";
//		cin >> Balo[i].giatri;
//	}
//}
//void duyet1(int v)
//{
//	for (int i = 0; i < n; i++)
//	{
//		if (tong + Balo[i].kichthuoc <= m)
//		{
//			tong = tong + Balo[i].kichthuoc;
//			giatri = giatri + Balo[i].giatri;
//			if (giatri > maxd)
//				maxd = giatri;
//			duyet1(v + 1);
//			tong = tong - Balo[i].kichthuoc;
//			giatri = giatri - Balo[i].giatri;
//
//
//		}
//	}
//}
////int main()
////{
////	tong = 0;
////	giatri = 0;
////	maxd = 0;
////	input();
////	duyet1(1);
////	printf("\nGia tri lon nhat co the cam theo la: %d", maxd);
////	system("PAUSE");
////	return 0;
////}