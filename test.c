#include <stdio.h>
struct ip_id
{
		int sockID;
		char *ip_addr;		
};
int main()
{
	char buf[20];
	char *p="192.168.0.1";
	int i;
	buf[5]=*p;
	printf("%c",buf[5]);
	for(i=0;p!="\0";i++){
	//	printf("%d\n",i);
		buf[i]=*p;
		
	//	printf("%s\n",buf);
		p++;
}

}

