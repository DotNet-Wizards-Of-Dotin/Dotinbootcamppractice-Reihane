#include <iostream>
#include <conio.h>
using namespace std;
main()
{
	int a ;
	cin>>a ;
	int i ;
	if(a%2==0)
	cout<<"no";
	else{
		for(i=3 ;i<a ;i++)
		if(a%i==0)
		cout<<"no";
		exit(0);
		else
		cout<<"yes";
	}
	
}




