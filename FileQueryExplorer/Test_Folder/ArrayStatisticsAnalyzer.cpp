#include <iostream>
#include <conio.h>
#include <iomanip>
using namespace std ;
 
void f(int a[],int size)
 {
  for(int i=0;i<size;i++)
    cout<<"  "<<a[i];
 }
void mean(int a[],int size){
	int sum=0 ;
	for(int j=0;j<size;j++)
	{sum+=a[j] ;} ;
	cout<<fixed<<setprecision(2) ;
    cout<<"mean: "<<static_cast<double> (sum)/size ;	
    
	
	
}
 void b(int a[],int size){    
        int hold ;
        int sum ;
       for(int r=0;r<size-1;r++)
       for(int k=0;k<size-1;k++)
 	   { if(a[k]<a[k+1])
 	    { hold=a[k];
 	      a[k]=a[k+1];
 	      a[k+1]=hold;
		}
	    
		}
		 for(int z=0;z<size;z++)
		 cout<<"a["<<z<<"] :"<<a[z]<<"   "; 	
         if(size%2!=0)
         cout<<"miane: "<<a[(size-1)/2] ;
		else
		 sum=(size-1)/2;
		   cout<<"miane: "<<(a[sum]+a[sum+1])/2 ;
 }
 void mod(int a[],int size){
 	int f[6]={0};
 	int index ;
 for(int t=0;t<=size;t++)
 	  ++f[a[t]];
    int max=f[a[t]];
    for(int e=a[t+1];e<=a[size];e++)
         if(f[e]>max)
 	      { max=f[e];
		   	index=e ;
     	   }
     	   cout<<"mod: "<<a[f[index]] ;
}
 main(){
 	int size=6 ;
    int a[size]={20,2,16,2,20,2} ;
 	f(a,size);
 	cout<<endl;
 	mean(a,size) ;
 	cout<<endl ;
 	b(a,size);
 	cout<<endl ;
 	mod(a,size);
 }
