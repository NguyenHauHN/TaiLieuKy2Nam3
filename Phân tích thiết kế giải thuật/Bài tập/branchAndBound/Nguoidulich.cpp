//
//#include<stdio.h>
//int c[10][10], x[10], xmin[10], mark[10], i, j, k, n, cost = 0, cmin, fmin = 1000;
//
////void readfile()
////{
////	FILE *f;
////	f = fopen("bai toan nguoi du lich.txt", "r");
////	fscanf(f, "%d", &n);
////	for (i = 1; i <= n; i++)
////		for (j = 1; j <= n; j++)
////			fscanf(f, "%d", &c[i][j]);
////	fclose(f);
////}
//void init()
//{
//	cmin = c[1][2];
//	for (i = 1; i <= n; i++)
//	{
//		mark[i] = 1;
//		for (j = 1; j <= n; j++)
//			if (i != j&&cmin>c[i][j])
//				cmin = c[i][j];
//	}
//	x[1] = 1;
//	mark[1] = 0;
//}
//void updatebest()
//{
//	int sum;
//	sum = cost + c[x[n]][x[1]];
//	if (sum<fmin)
//	{
//		fmin = sum;
//		for (i = 1; i <= n; i++)
//			xmin[i] = x[i];
//	}
//}
//void branch_bound(int k)
//{
//	for (j = 2; j <= n; j++)
//		if (mark[j])
//		{
//			x[k] = j;
//			mark[j] = 0;
//			cost = cost + c[x[k - 1]][x[k]];
//			if (k == n)
//				updatebest();
//			else
//				if ((cost + cmin*(n - k + 1))<fmin)
//					branch_bound(k + 1);
//			mark[j] = 1;
//			cost = cost - c[x[k - 1]][x[k]];
//		}
//}
//void result()
//{
//	printf("Chi phi nho nhat la: %d", fmin);
//	printf("\nHanh trinh nho nhat la: ");
//	for (i = 1; i <= n; i++)
//	{
//		printf("%d", xmin[i]);
//		printf("->");
//	}
//	printf("1");
//}
////int main()
////{
////	readfile();
////	init();
////	branch_bound(2);
////	result();
////}