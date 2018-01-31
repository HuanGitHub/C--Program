#include <sys/types.h>
#include <stdio.h>
#include <sys/socket.h>
#include <netinet/ip.h>
#include <netinet/in.h>
#include <unistd.h>
#include <string.h>
#include <arpa/inet.h>
#include <pthread.h>
void *pthread_write(void *ad);
void *pthread_read(void *fd);
struct IP_ID{
	int ID;
	char *IP;		

};
int main()
{
	int sockfd,nfd;
	struct IP_ID ip_id[5];
	pthread_t p_r,p_w;
	sockfd=socket(AF_INET,SOCK_STREAM,0);
	if(sockfd==-1)
	{
		printf("creat socket fail");
		return 1;
	}
	struct sockaddr_in addr,naddr;
	addr.sin_family=AF_INET;
	addr.sin_port=htons(8080);
	addr.sin_addr.s_addr=inet_addr("127.0.0.1");
	if((bind(sockfd,(void*)&addr,sizeof(addr))==-1))
	{
		printf("creat bind fail");
		return 1; 
	}
	int ii=0,stl,l=0,i=0;
	listen(sockfd,5);
	char buft[20];
	while(1)
	{
		nfd=accept(sockfd,(void*)&naddr,&stl);		
		char *k=inet_ntoa(naddr.sin_addr);
		for(i=0;;i++)
		{	
		}
		printf("the sockfd=%d\nthe client IP:  %s\n",nfd,k);
		pthread_create(&p_r,NULL,pthread_read,&nfd);	
		pthread_create(&p_w,NULL,pthread_write,&nfd);
		for(i=0;k!=ip_id[i].IP&&i<5;i++)
{			
			ip_id[ii].IP=k;
			
			ip_id[ii].ID=i;
			printf("the ip_id.[%d].IP  value: %s\n",i,ip_id[ii].IP);			
			printf("the ip_id.[%d].ID  value: %d\n",i,ip_id[ii].ID);			
			ii++;
		break;
}
}
	//	ip_addr[1]=*ad;
	//	printf("%c\n",ip_addr[1]);
		printf("l the valte:%d\n",l);

	close(nfd);
	close(sockfd);

}
void *pthread_read(void *ad)
{	
	char buf[100];	
	int td=*(int *)ad;
//	printf("%d",td);
	read(td,buf,sizeof(buf));
//	printf("%s\n",buf);

}
void *pthread_write(void *ad)
{
	char buf[100];
	int td=*(int *)ad;
//	printf("%d",td);
	write(td,"zhang",sizeof(buf));
//	printf("%s\n",buf);

}
